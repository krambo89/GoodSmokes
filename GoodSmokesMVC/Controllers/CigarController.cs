using ClassLibrary1;
using GoodSmokes.Data;
using GoodSmokes.Models;
using GoodSmokesService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSmokesMVC.Controllers
{
    public class CigarController : Controller
    {
        // GET: Cigar
        private ApplicationDbContext _db = new ApplicationDbContext();
        
        public ActionResult Index()
        {
            var service = CreateCigarService();
            var model = service.GetCigars();
            return View(model);
        }
        // POST: Cigar/Create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CigarCreate model)
        {
            var service = CreateCigarService();

            if (service.CreateCigar(model))
            {
                TempData["SaveResult"] = "Your Cigar was created.";
                return RedirectToAction("Index");
            }


            ModelState.AddModelError("", "Cigar could not be created");
            return View(model);
        }

        


        public ActionResult Details(int id)
        {

            var svc = CreateCigarService();
            var model = svc.GetCigarById(id);
            return View(model);
        }

        public ActionResult Edit(int id)
        {

            var service = CreateCigarService();
            var detail = service.GetCigarById(id);
            var model =
                new CigarEdit
                {
                    CigarId = detail.CigarId,
                    CigarName = detail.CigarName,
                    MakerId = detail.MakerId,
                    CigarTypeId = detail.CigarTypeId
                };

            return View(model);
        }

        [HttpPost]
        
        public ActionResult Edit(int id, CigarEdit model)
        {
            if (!ModelState.IsValid)
            {


                return View(model);
            }

            if (model.CigarId != id)
            {

                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateCigarService();

            if (service.UpdateCigar(model))
            {
                TempData["SaveResult"] = "Your cigar was updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your cigar could not be updated.");
            return View();
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateCigarService();
            var model = svc.GetCigarById(id);

            return View(model);
        }

        // POST: Note/Delete/{id}
        [HttpPost]
        [ActionName("Delete")]
        
        public ActionResult DeleteCigar(int id)
        {
            var service = CreateCigarService();
            service.DeleteCigar(id);

            TempData["SaveResult"] = "Your cigar was deleted.";
            return RedirectToAction("Index");
        }

        private CigarService CreateCigarService()
        {

            var service = new CigarService();
            return service;
        }

    }
}