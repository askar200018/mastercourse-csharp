using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// ********** PRO TIP **************
// Razor pages make page structure easy -
// where your page is determines the route.

namespace MyApp.Namespace
{
    public class PersonsInfoModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public int Age { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
