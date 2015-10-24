namespace PhC.App.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Model;
    using Model.Enums;
    using Models.ViewModels;

    public class HomeController : BaseController
    {
        public ActionResult Index(int? page, string type)
        {
            IQueryable<Contest> contests = this.Data.Contests.All();
            IQueryable<ContestConciseViewModel> resultContests = null;
            int pageSize = 5;
            int pageNumber = page == null ? 1 : int.Parse(page.ToString());
            pageNumber = pageNumber < 1 ? 1 : pageNumber;
            int skips = (pageNumber - 1) * pageSize;

            ViewBag.pageNumber = pageNumber;
            ViewBag.type = type;

            contests = type == "past" ? contests.Where(c => c.State != ContestState.Active) : contests.Where(c => c.State == ContestState.Active);

			resultContests = contests.OrderByDescending(c => c.CreatedOn).Skip(skips).Take(pageSize).ProjectTo<ContestConciseViewModel>();
            

            return View(resultContests);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}