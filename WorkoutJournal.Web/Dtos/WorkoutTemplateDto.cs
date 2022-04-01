namespace WorkoutJournal.Web.Dtos;

public record WorkoutTemplateDto(
    Guid Id, string Name, string Description, DateTime LastUpdated);

