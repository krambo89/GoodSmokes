using ClassLibrary1;
using GoodSmokes.Data;
using GoodSmokes.Models;
using GoodSmokes.Models.CigarMaker;
using GoodSmokesService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSmokesMVC.Controllers
{
    [Authorize]
    public class CigarMakerController : Controller
    {

        // GET: CigarMaker

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Index()
        {
            var model = new CigarMakerListItems[0];
            return View(model);
        }
        // POST: CigarMaker/Create

        [HttpPost]
        public ActionResult Create(CigarMakerCreate model)
        {
            var service = CreateCigarMakerService();

            if (service.CreateCigarMaker(model))
            {
                TempData["SaveResult"] = "Your Maker was created.";
                return RedirectToAction("Index");
            }


            ModelState.AddModelError("", "Maker could not be created");
            return View(model);
        }

        public ActionResult Details(int id)
        {

            var svc = CreateCigarMakerService();
            var model = svc.GetCigarMakerById(id);
            return View(model);
        }

        public ActionResult Edit(int id)
        {

            var service = CreateCigarMakerService();
            var detail = service.GetCigarMakerById(id);
            var model =
                new CigarMakerEdit
                {
                    
                    MakerName = detail.MakerName,
                    
                };

            return View(model);
        }

        [HttpPost]

        public ActionResult Edit(int id, CigarMakerEdit model)
        {
            if (!ModelState.IsValid)
            {


                return View(model);
            }

            if (model.MakerId != id)
            {

                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateCigarMakerService();

            if (service.UpdateCigarMaker(model))
            {
                TempData["SaveResult"] = "Your cigar maker was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your cigar maker could not be updated.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateCigarMakerService();
            var model = svc.GetCigarMakerById(id);

            return View(model);
        }

        // POST: Note/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]

        public ActionResult DeleteCigarMaker(int id)
        {
            var service = CreateCigarMakerService();
            service.DeleteCigarMaker(id);

            TempData["SaveResult"] = "Your cigar maker was deleted.";
            return RedirectToAction("Index");
        }

        private CigarMakerService CreateCigarMakerService()
        {

            var service = new CigarMakerService();
            return service;
        }
    }
}