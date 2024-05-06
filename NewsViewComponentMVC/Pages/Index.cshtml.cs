using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsViewComponentMVC.Models;

namespace NewsViewComponentMVC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly NewsDbContext _newsDb;

        public IndexModel(NewsDbContext newsDb)
        {
            this._newsDb = newsDb;
        }
        public void OnGet()
        {
            _newsDb.News.ToList();
            
        }
    }
}
