using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class AddressModel : PageModel
    {
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string Street { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
