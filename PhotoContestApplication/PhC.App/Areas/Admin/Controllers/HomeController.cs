namespace PhC.App.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    public class HomeController : BaseAdminController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            
            return View();
        }
    }
}