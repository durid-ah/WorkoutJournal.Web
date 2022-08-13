using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutJournal.Web.Dtos;

namespace WorkoutJournal.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public List<WorkoutTemplateDto> Templates { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> OnGet()
    {
        await Task.FromResult(0);

        Templates = new List<WorkoutTemplateDto>
        {
            new WorkoutTemplateDto 
            (
                Guid.NewGuid(), 
                "Test Workout", 
                "Just a test template",
                DateTime.Now
            ),
            new WorkoutTemplateDto
            (
                Guid.NewGuid(),
                "Test Workout 2",
                "Just a test template",
                DateTime.Now
            )
        };

        return Page();
    }
}
