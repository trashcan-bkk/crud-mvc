using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crud_mvc.Models;

namespace crud_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _db;
        public HomeController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            var contents = (from c in _db.Contents
                           orderby c.CreatedDate descending
                           select c).Take(3).ToList();

            return View(contents);
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFeedback(Feedback feedback)
        {
            feedback.Date = DateTime.Now;
            _db.Feedbacks.Add(feedback);
            _db.SaveChanges();
            Index();
            return RedirectToAction("Index");
        }
    }
}
