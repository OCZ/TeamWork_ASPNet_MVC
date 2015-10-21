namespace PhC.App.Controllers
{
    using System.Web.Mvc;
    using Model;
    using Model.Enums;

    public class ContestController : Controller
    {
        public ActionResult NewContest()
        {
            var contest = new Contest();

            return this.Content("OK");
        }
    }
}