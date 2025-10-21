using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lottery.Helper;

namespace Lottery.Pages.Loto
{
    public class Loto6x45Model : PageModel
    {
        public List<int> Numbers { get; private set; } = new();

        public void OnGet()
        {
            Numbers = LotoNumberGenerator.Generate(6, 45);
        }
    }
}
