using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lottery.Helper;

namespace Lottery.Pages.Loto
{
    public class Loto7x39Model : PageModel
    {
        public List<int> Numbers { get; private set; } = new();

        public void OnGet()
        {
            Numbers = LotoNumberGenerator.Generate(7, 39);
        }
    }
}