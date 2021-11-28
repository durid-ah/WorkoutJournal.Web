using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Data.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

    public DbSet<ExerciseTemplate> ExerciseTemplates { get; set; }

}

class ExcerciseConfiguration : IEntityTypeConfiguration<ExerciseTemplate>
{
    public void Configure(EntityTypeBuilder<ExerciseTemplate> builder)
    {
        throw new NotImplementedException();
    }
}

