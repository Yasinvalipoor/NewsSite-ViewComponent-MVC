using Microsoft.AspNetCore.Mvc;
using NewsViewComponentMVC.Models;


public class HomeController : Controller
{
    private readonly NewsDbContext _newsDb;

    public HomeController(NewsDbContext newsDb)
    {
        this._newsDb = newsDb;
    }
    public IActionResult Index()
    {
        return View(/*_newsDb.News.ToList()*/);
    }
}

