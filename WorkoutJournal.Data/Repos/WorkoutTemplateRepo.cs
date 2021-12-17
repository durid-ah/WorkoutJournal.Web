using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Data.Data;
using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Data.Repos;

public class WorkoutTemplateRepo
{
    private readonly AppDbContext context;

    public WorkoutTemplateRepo(AppDbContext context)
    {
        this.context=context;
    }

    public async Task<List<WorkoutTemplate>> GetUserTemplates(int userId)
    {
        return await context.WorkoutTemplates
            .Where(wt => wt.OwnerId == userId).ToListAsync();
    }

    public async Task<WorkoutTemplate?> GetUserTemplate(int userId, Guid templateId)
    {
        return await context.WorkoutTemplates
            .FirstOrDefaultAsync(wt => wt.OwnerId == userId && wt.Id == templateId);
    }

    public async Task<WorkoutTemplate> AddUserTemplate(WorkoutTemplate template)
    {
        context.WorkoutTemplates.Add(template);
        await context.SaveChangesAsync();
        return template;
    }

    public async Task<WorkoutTemplate> DeleteUserTemplate(WorkoutTemplate template)
    {
        var toDelete = await context
            .WorkoutTemplates
            .FirstOrDefaultAsync(
                wt => wt.Id == template.Id && wt.OwnerId == template.OwnerId);
        context.WorkoutTemplates.Remove(toDelete);
        await context.SaveChangesAsync();
        return template;
    }


}

