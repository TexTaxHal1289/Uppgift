using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Uppgift.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Email { get; set; }
        [BindProperty] public bool Hardricksvatten { get; set; }
        [BindProperty] public bool harficklampa { get; set; }

        [BindProperty] public bool harradio { get; set; }

        public bool skickad { get; set; }
        public void OnGet()
        {

        }
        public void OnPost() 
        {
        skickad = true;

        }
      
            };

         
        }

