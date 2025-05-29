using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StockPortfolioTracker.Models;

namespace MyApp.Namespace
{
    public class PortfolioModel : PageModel
    {
        public Portfolio MyPortfolio { get; set; }
        public void OnGet()
        {
            MyPortfolio = new Portfolio();
        }

        [BindProperty]
        public string Symbol { get; set; }

        [BindProperty]
        public int Quantity { get; set; }

        [BindProperty]
        public decimal Price { get; set; }

        public IActionResult OnPost()
        {
            Portfolio MyPortfolio = new Portfolio();
            if (!string.IsNullOrWhiteSpace(Symbol) && Quantity > 0 && Price > 0)
            {
                MyPortfolio.AddStock(new Stock { Symbol = Symbol, Quantity = Quantity, Price = Price });
            }
            return RedirectToPage();
        }

    }
    

}
