using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            return View();
        }

        DXWebApplication1.Models.Nwind_SalesDataEntities db = new DXWebApplication1.Models.Nwind_SalesDataEntities();

        [ValidateInput(false)]
        public ActionResult PivotGridPartial()
        {
            var model = db.SalesPersons;
            return PartialView("_PivotGridPartial", model.ToList());
        }
    }
}