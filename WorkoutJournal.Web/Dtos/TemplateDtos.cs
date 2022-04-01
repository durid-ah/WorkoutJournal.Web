using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Web.Dtos;

public record ExerciseTemplateDto(
    string Name, string Description, WeightUnit WeightUnit, RepType RepType);

public record WorkoutTemplateDto(
    Guid Id, string Name, string Description, DateTime LastUpdated);

public record TemplateDtos(
    WorkoutTemplateDto Workout, List<ExerciseTemplateDto> Exercises);
