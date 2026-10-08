using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Uppgift.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        [Required(ErrorMessage = "Namn krävs")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "E-post krävs")]
        [EmailAddress(ErrorMessage = "Ogiltig e-postadress")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Du måste svara Ja eller Nej")]
        public bool? Hardricksvatten { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Du måste svara Ja eller Nej")]
        public bool? Harmatfor3dagar { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Du måste svara Ja eller Nej")]
        public bool? harficklampa { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Du måste svara Ja eller Nej")]
        public bool? harradio { get; set; }

        [BindProperty]
        public string EgnaTips { get; set; }

        public bool skickad { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            skickad = true;
            return Page();
        }
    }
}