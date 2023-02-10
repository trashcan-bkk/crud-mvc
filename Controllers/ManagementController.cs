using System;
using System.IO;
using System.Linq;
using crud_mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud_mvc.Controllers
{
    public class ManagementController : Controller
    {
        private readonly DatabaseContext _db;

        public ManagementController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet("/management")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                var contents = _db.Contents.ToList();
                return View(contents);
                
                //var info = (from c in db.Accounts
                        //where c.Username == HttpContext.Session.GetString("username")
                        //select c).ToList();

                //return View(info);
            }
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View("Add", new Content());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Content content, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string pathImg = "/img/";
                string pathSave = $"wwwroot{pathImg}";
                if (!Directory.Exists(pathSave))
                {
                    Directory.CreateDirectory(pathSave);
                }
                string extFile = Path.GetExtension(file.FileName);
                string fileName = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + extFile;
                var path = Path.Combine(Directory.GetCurrentDirectory(), pathSave, fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                content.CoverImg = pathImg + fileName;

                DateTime date = DateTime.Now;
                content.CreatedDate = date;
                content.UpdatedDate = null;
            }

            _db.Contents.Add(content);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _db.Contents.Remove(_db.Contents.Find(id));
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var content = _db.Contents.Find(id);
            return View("Edit", content);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Content content, IFormFile file)
        {
            Content oldContent = _db.Contents.Find(id);
            content.CoverImg = oldContent.CoverImg;

            if (ModelState.IsValid)
            {
                string pathImg = "/img/";
                string pathSave = $"wwwroot{pathImg}";
                if (!Directory.Exists(pathSave))
                {
                    Directory.CreateDirectory(pathSave);
                }
                string extFile = Path.GetExtension(file.FileName);
                string fileName = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + extFile;
                var path = Path.Combine(Directory.GetCurrentDirectory(), pathSave, fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                content.CoverImg = pathImg + fileName;

                DateTime date = DateTime.Now;
                content.UpdatedDate = date;
            }

            _db.Entry(content).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}