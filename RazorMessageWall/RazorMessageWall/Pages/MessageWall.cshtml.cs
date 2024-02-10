using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


// ******* PRO TIP ***********
// Razor pages are best used for simple web applications
// rather than as the backbone for SPAs.

namespace MyApp.Namespace
{
    public class MessageWallModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Messages.Add(Message);
            return Page();
        }
    }
}
