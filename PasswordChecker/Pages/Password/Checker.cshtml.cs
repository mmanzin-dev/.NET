using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PasswordChecker.Model;

namespace PasswordChecker.Pages.Password.Checker;

public class CheckerModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public Model.Password Password { get; set; }

    public CheckerModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        Password = new Model.Password();
    }

    public void OnGet()
    {

    }

    public void OnPost()
    {
        Password.Value = Request.Form["Password.Value"];

        if (string.IsNullOrEmpty(Password.Value))
        {
            ViewData["Message"] = "Please enter a password.";
            return;
        }
        else
        {
            if (Password.Value.Length < 8)
            {
                ViewData["Message"] = "Password is too short. It should be at least 8 characters long.";
                return;
            }

            if (!Password.Value.Any(char.IsUpper))
            {
                ViewData["Message"] = "Password must contain at least one uppercase letter.";
                return;
            }

            if (!Password.Value.Any(char.IsLower))
            {
                ViewData["Message"] = "Password must contain at least one lowercase letter.";
                return;
            }

            ViewData["Message"] = "Password is valid.";
            return;
        }
    }
}
