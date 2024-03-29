﻿namespace WorkoutJournal.Data.Data.Models;

public class ExerciseTemplate
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public WeightUnit WeightUnit { get; set; }
    public RepType RepType { get; set; }
    public Guid WorkoutTemplateId { get; set; }
    public WorkoutTemplate WorkoutTemplate { get; set; }
    public List<ExerciseSet> TargetSets { get; set; }
}

public enum WeightUnit
{
    KG,
    LBS
}

public enum RepType
{
    Timed,
    Count
}
