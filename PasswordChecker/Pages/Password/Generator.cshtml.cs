using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PasswordChecker.Pages.Password.Generator;

public class GeneratorModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;


    public List<Model.Password> GeneratedPasswords { get; set; }

    public GeneratorModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        GeneratedPasswords = new List<Model.Password>();
        for (int i = 0; i < 10; i++)
        {
            var password = new Model.Password();
            password.Value = GeneratePassword(10);
            GeneratedPasswords.Add(password);
        }
    }
    
    private string GeneratePassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";
        Random random = new Random();
        return new string(Enumerable.Repeat(validChars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
