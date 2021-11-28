namespace WorkoutJournal.Data.Data.Models;

public class ExerciseTemplate
{
    public int ExerciseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public WeightUnit WeightUnit { get; set; }
    public RepType RepType { get; set; }
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
