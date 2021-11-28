using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Data.Data.Config;

public class ExerciseTemplateConfig : IEntityTypeConfiguration<ExerciseTemplate>
{
    public void Configure(EntityTypeBuilder<ExerciseTemplate> builder)
    {
        builder
            .Property(et => et.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(et => et.Description)
            .HasMaxLength(250);

        builder.Property(et => et.WeightUnit)
                .HasConversion(
                    wu => wu.ToString(),
                    wus => (WeightUnit)Enum.Parse(typeof(WeightUnit), wus));

        builder.Property(et => et.RepType)
        .HasConversion(
            rt => rt.ToString(),
            rts => (RepType)Enum.Parse(typeof(RepType), rts));

        builder
            .Property(x => x.TargetSets)
            .HasJsonConversion();
    }
}