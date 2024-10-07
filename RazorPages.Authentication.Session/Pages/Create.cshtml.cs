using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Authentication.Session.Model;

namespace RazorPages.Authentication.Session.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Login login { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("login", login.UserName);
                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
