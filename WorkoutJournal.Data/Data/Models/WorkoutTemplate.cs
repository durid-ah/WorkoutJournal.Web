using System.ComponentModel.DataAnnotations;

namespace WorkoutJournal.Data.Data.Models;

public class WorkoutTemplate
{
    [Key]
    public Guid Id { get; set; }
    public int OwnerId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime LastUpdated { get; set; }
    public ICollection<ExerciseTemplate> Exercises { get; set; }
}

