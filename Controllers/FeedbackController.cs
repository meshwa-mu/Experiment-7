
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Experiment_7.Models;

namespace Experiment_7.Controllers
{
    public class FeedbackController : Controller
    {
        private static readonly List<Feedback> feedbackList =
            new List<Feedback>();

        public ActionResult Index()
        {
            return View(feedbackList);
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.Id = feedbackList.Count == 0
                    ? 1
                    : feedbackList.Max(f => f.Id) + 1;

                feedback.SubmittedOn = DateTime.Now;
                feedbackList.Add(feedback);

                TempData["Message"] =
                    "Feedback submitted successfully!";

                return RedirectToAction("Index");
            }

            return View(feedback);
        }
    }
}