using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Conference1.Domain.Entities;
using Conference1.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoferenceMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SpeakersController : Controller
    {
        private readonly ISpeakerService speakerService;

        public SpeakersController(ISpeakerService speakerService)
        {
            this.speakerService = speakerService;
        }

        // GET: Speakers
        public ActionResult Index()
        {
            var allSpeakers = speakerService.GetAllSpeakers();
            return View(allSpeakers);
        }

        // GET: Speakers/Details/5
        public ActionResult Details(int id)
        {
            Speakers speaker = speakerService.GetSpeakerById(id);
            return View(speaker);
        }

        // GET: Speakers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Speakers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Speakers model)
        {
            if (ModelState.IsValid)
            {
                Speakers addedSpeaker = speakerService.AddSpeaker(model);
                if (addedSpeaker != null)
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

        // GET: Speakers/Edit/5
        public ActionResult Edit(int id)
        {
            Speakers speakerToEdit = speakerService.GetSpeakerById(id);
            return View(speakerToEdit);
        }

        // POST: Speakers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Speakers model)
        {
            if (ModelState.IsValid)
            {
                var existingSpeaker = speakerService.GetSpeakerById(id);
                TryUpdateModelAsync(existingSpeaker);
                speakerService.UpdateSpeaker(existingSpeaker);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        // GET: Speakers/Delete/5
        public ActionResult Delete(int id)
        {
            Speakers speakerToDelete = speakerService.GetSpeakerById(id);
            speakerService.DeleteSpeaker(speakerToDelete);
            return RedirectToAction(nameof(Index));
        }

        // POST: Speakers/Delete/5
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