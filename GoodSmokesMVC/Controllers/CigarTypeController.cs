using GoodSmokes.Models.CigarType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSmokesMVC.Controllers
{
    [Authorize]
    public class CigarTypeController : Controller
    {
        // GET: CigarType
        public ActionResult Index()
        {
            var model = new CigarTypeListItems[0];
            return View(model);
        }
     

        public ActionResult Create()
        {

            return View();
        }
    }
}