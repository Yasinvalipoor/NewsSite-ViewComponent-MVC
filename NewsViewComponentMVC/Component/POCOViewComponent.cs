using NewsViewComponentMVC.Models;

namespace NewsViewComponentMVC.Component
{
    public class POCOViewComponent
    {
        private readonly NewsDbContext _newsDb;

        public POCOViewComponent(NewsDbContext newsDb)
        {
            this._newsDb = newsDb;
        }

        public string Invoke()
        {
            return _newsDb.News.Where(c=>c.Id==1).FirstOrDefault()?.Title;
        }
    }
 }
