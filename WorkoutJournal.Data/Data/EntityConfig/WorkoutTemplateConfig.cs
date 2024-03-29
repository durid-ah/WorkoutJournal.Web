﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Data.Data.EntityConfig;

public class WorkoutTemplateConfig : IEntityTypeConfiguration<WorkoutTemplate>
{
    public void Configure(EntityTypeBuilder<WorkoutTemplate> builder)
    {
        builder.Property(wt => wt.Id)
            .ValueGeneratedNever();

        builder.Property(wt => wt.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(wt => wt.Name)
            .HasMaxLength(250);

        builder.Property(wt => wt.LastUpdated)
            .IsRequired();

        builder.Property(wt => wt.OwnerId)
            .IsRequired();

        builder.HasOne<Owner>()
            .WithMany()
            .HasForeignKey(wt => wt.OwnerId);
    }
}
