namespace PhC.App.Controllers
{
    using System.Net;
    using System.Web.Mvc;
    using AutoMapper;
    using Model;
    using Model.Enums;

    public class ContestController : BaseController
    {
        // GET: Contests/Details/1
        public ActionResult Details(int id)
        {
            var contest = this.Data.Contests.Find(id);
            if (contest == null)
            {
                return this.HttpNotFound();
            }

            //var contestModel = Mapper.Map<Contest, ContestFullViewModel>(contest);
            return View();
        }

       
       
        public ActionResult NewContest()
        {
            var contest = new Contest();

            return this.Content("OK");
        }







    }
}