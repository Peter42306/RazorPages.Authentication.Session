using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Authentication.Session.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("login")==null)
            {
                return RedirectToPage("Create");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            return RedirectToAction("Logout");
        }
    }
}
