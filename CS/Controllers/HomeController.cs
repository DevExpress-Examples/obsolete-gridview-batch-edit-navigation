using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T283418.Models;

namespace T283418
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GridViewPartial()
        {
            var model = Data.GetData();
            return PartialView(model);
        }
        public ActionResult GridViewBatchUpdatePartial(MVCxGridViewBatchUpdateValues<int, Data> values)
        {
            var model = Data.GetData();
            return PartialView("GridViewPartial", model);
        }
    }
}