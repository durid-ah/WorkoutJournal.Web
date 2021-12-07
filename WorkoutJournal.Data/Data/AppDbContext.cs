using Microsoft.EntityFrameworkCore;
using WorkoutJournal.Data.Data.Config;
using WorkoutJournal.Data.Data.EntityConfig;
using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Data.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

    public DbSet<ExerciseTemplate> ExerciseTemplates { get; set; }
    public DbSet<WorkoutTemplate> WorkoutTemplates { get; set; }
    public DbSet<Owner> Owners { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ExerciseTemplateConfig());
        builder.ApplyConfiguration(new WorkoutTemplateConfig());
    }
}
