
namespace WorkoutJournal.Data.Data.Models;

public class ExerciseSet
{
    public int Reps { get; set; }
    public decimal Weight { get; set; }
    public WeightUnit WeightUnit { get; set; }
}

public enum WeightUnit
{
    KG,
    LBS
}
