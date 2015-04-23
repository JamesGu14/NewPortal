using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using WEB.Models;
namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Application()
        {
            var emodels = new EsuperfundUserModels();
            emodels.ID = 1;
            emodels.FundName = "test fund";
            emodels.FundTFN = "111 222 333";
            emodels.ABN = "11122233311";
            emodels.EmailAddress = "test@test.com";
            ViewBag.data = emodels;
            return View(ViewBag);
        }
      
        
    }
}
