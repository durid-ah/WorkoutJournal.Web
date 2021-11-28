namespace WorkoutJournal.Data.Data.Models;

public class ExerciseTemplate
{
    public string Name { get; set; }
    public List<ExerciseSet> TargetSets { get; set; }

}
