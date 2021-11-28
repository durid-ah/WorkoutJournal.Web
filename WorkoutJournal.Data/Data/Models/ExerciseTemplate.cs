using Newtonsoft.Json.Linq;

namespace WorkoutJournal.Data.Data.Models;

public class ExerciseTemplate
{
    public string Name { get; set; }
    public JObject Sets { get; set; }

}
