using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference1.Domain.Entities;
using Conference1.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoferenceMVC.Controllers
{
    public class EditionController : Controller
    {
        private readonly IEditionService editionsService;

        public EditionController(IEditionService editionsService)
        {
            this.editionsService = editionsService;
        }

        // GET: Edition
        public ActionResult Index()
        {
            var allEditions = editionsService.GetAllEditions();
            return View(allEditions);
        }

        // GET: Edition/Details/5
        public ActionResult Details(int id)
        {
            Editions edition = editionsService.GetEditionById(id);
            return View(edition);
        }

        // GET: Edition/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Edition/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Editions model)
        {
            if (ModelState.IsValid)
            {
                Editions addedEdition = editionsService.AddEdition(model);
                if (addedEdition != null)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        // GET: Edition/Edit/5
        public ActionResult Edit(int id)
        {
            var editionToEdit = editionsService.GetEditionById(id);
            return View(editionToEdit);
        }

        // POST: Edition/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Editions model)
        {
            if (ModelState.IsValid)
            {
                var existingEdition = editionsService.GetEditionById(id);
                TryUpdateModelAsync(existingEdition);
                editionsService.Update(existingEdition);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Edition/Delete/5
        public ActionResult Delete(int id)
        {
            Editions editionToDelete;
            editionToDelete = editionsService.GetEditionById(id);
            if (editionToDelete != null)
            {
                editionsService.Delete(editionToDelete);
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Edition/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
