using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Data.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

    public DbSet<ExerciseTemplate> ExerciseTemplates { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ExerciseTemplate>()
            .Property(x => x.TargetSets)
            .HasJsonConversion();
    }
}