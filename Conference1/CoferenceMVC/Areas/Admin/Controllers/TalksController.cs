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
    public class TalksController : Controller
    {
        private readonly ITalksService talkService;

        public TalksController(ITalksService talkService)
        {
            this.talkService = talkService;
        }

        // GET: Talks
        public ActionResult Index()
        {
            var allTalks = talkService.GetAllTalks();
            return View(allTalks);
        }

        // GET: Talks/Details/5
        public ActionResult Details(int id)
        {
            Talks talk = talkService.GetTalkById(id);
            return View(talk);
        }

        // GET: Talks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Talks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Talks model)
        {
            if (ModelState.IsValid)
            {
                Talks addedTalk;
                addedTalk = talkService.AddTalk(model);
                if (addedTalk != null)
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

        // GET: Talks/Edit/5
        public ActionResult Edit(int id)
        {
            Talks talkToEdit = talkService.GetTalkById(id);
            return View(talkToEdit);
        }

        // POST: Talks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Talks model)
        {
            if (ModelState.IsValid)
            {
                Talks talkToUpdate = talkService.GetTalkById(id);
                TryUpdateModelAsync(talkToUpdate);
                Talks updatedTalk = talkService.UpdateTalk(talkToUpdate);
                if (updatedTalk != null)
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

        // GET: Talks/Delete/5
        public ActionResult Delete(int id)
        {
            Talks talkToDelete = talkService.GetTalkById(id);
            talkService.DeleteTalk(talkToDelete);
            return RedirectToAction(nameof(Index));
        }

        // POST: Talks/Delete/5
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