namespace PhC.App.Controllers
{
    using System.Web.Mvc;
    using AutoMapper;
    using Model;
    using Model.Enums;

    public class ContestController : BaseController
    {
        public ActionResult Details(int id)
        {
            var post = this.Data.Contests.Find(id);
            if (post == null)
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