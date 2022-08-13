using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using WorkoutJournal.Data.Data;
using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Data.Repos;

public class WorkoutTemplateRepo
{
    private readonly AppDbContext context;
    private readonly string NOT_FOUND_ERROR = "Entity not found";

    public WorkoutTemplateRepo(AppDbContext context)
    {
        this.context = context;
    }

    public async Task<Result<List<WorkoutTemplate>>> GetUserTemplates(int userId)
    {
        try
        {
            var res = await context.WorkoutTemplates
                .Where(wt => wt.OwnerId == userId).ToListAsync();

            return Result.Success(res);
        }
        catch (Exception e)
        {
            return Result.Failure<List<WorkoutTemplate>>(e.Message);
        }
        
    }

    public async Task<Result<WorkoutTemplate?>> GetUserTemplate(int userId, Guid templateId)
    {
        var res = await context.WorkoutTemplates
            .FirstOrDefaultAsync(wt => wt.OwnerId == userId && wt.Id == templateId);

        return Result.FailureIf(res == null, res, NOT_FOUND_ERROR);
    }

    public async Task<Result<WorkoutTemplate>> AddUserTemplate(WorkoutTemplate template)
    {
        try
        {

            context.WorkoutTemplates.Add(template);
            await context.SaveChangesAsync();
            return Result.Success(template);
        }
        catch (Exception e)
        {
            return Result.Failure<WorkoutTemplate>(e.Message);
        }
    }

    public async Task<Result<WorkoutTemplate>> DeleteUserTemplate(WorkoutTemplate template)
    {
        var toDelete = await context
            .WorkoutTemplates
            .FirstOrDefaultAsync(
                wt => wt.Id == template.Id && wt.OwnerId == template.OwnerId);

        if (toDelete == null)
            return Result.Failure<WorkoutTemplate>(NOT_FOUND_ERROR);

        context.WorkoutTemplates.Remove(toDelete);
        await context.SaveChangesAsync();
        return Result.Success(template);
    }

    public async Task<Result> DeleteUserTemplates(List<Guid> workoutIds)
    {
        var toDelete = await context
            .WorkoutTemplates
            .Where(wt => workoutIds.Contains(wt.Id))
            .ToListAsync();

        if (toDelete == null)
            return Result.Failure(NOT_FOUND_ERROR);

        context.WorkoutTemplates.RemoveRange(toDelete);
        await context.SaveChangesAsync();
        return Result.Success();
    }

    public  async Task<Result<WorkoutTemplate>> UpdateUserTemplate(WorkoutTemplate template, int ownerId)
    {
        var toUpdate = await context.WorkoutTemplates
            .FirstOrDefaultAsync(
                wt => wt.Id == template.Id && wt.OwnerId == ownerId);

        if (toUpdate == null)
            return Result.Failure<WorkoutTemplate>(NOT_FOUND_ERROR);

        toUpdate.UpdateTemplate(template.Name, template.Description);
        
        await context.SaveChangesAsync();
        return Result.Success(toUpdate);
    }

    public async Task<Result<WorkoutTemplate?>> UpdateUserTemplates(List<WorkoutTemplate> template, int ownerId)
    {
        //var toUpdate = await context.WorkoutTemplates
        //    .FirstOrDefaultAsync(
        //        wt => wt.Id == template.Id && wt.OwnerId == ownerId);

        //if (toUpdate == null)
        //    return Result.Failure<WorkoutTemplate>(NOT_FOUND_ERROR);

        //toUpdate.UpdateTemplate(template.Name, template.Description);

        await context.SaveChangesAsync();
        return null;// Result.Success(toUpdate);
    }
}

