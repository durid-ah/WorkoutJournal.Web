using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkoutJournal.Web.Dtos;

namespace WorkoutJournal.Web.Pages
{
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
            Templates = new List<WorkoutTemplateDto>
            {
                new WorkoutTemplateDto 
                { 
                    Id = Guid.NewGuid(), 
                    Name = "Test Workout", 
                    Description = "Just a test template",
                    LastUpdated = DateTime.Now,
                },
                new WorkoutTemplateDto
                {
                    Id = Guid.NewGuid(),
                    Name = "Test Workout 2",
                    Description = "Just a test template",
                    LastUpdated = DateTime.Now,
                }
            };

            return Page();
        }
    }
}