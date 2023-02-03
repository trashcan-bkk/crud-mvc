using System.Collections.Generic;
using System.Linq;
using crud_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crud_mvc.Controllers
{
    public class ContentController : Controller
    {
        private readonly DatabaseContext _db;
        public ContentController(DatabaseContext db)
        {
            _db = db;
        }

        [Route("/contents")]
        public IActionResult Index(int page = 1)
        {
            List<Content> contents = _db.Contents.ToList();

            const int pageSize = 6;
            if (page < 1) page = 1;

            int count = contents.Count();
            var pager = new Pager(count, page, pageSize);
            int skip = (page - 1) * pageSize;
            var data = contents.Skip(skip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager; 

            return View(data);
        }

        [Route("contents/{id}")]
        public IActionResult GetContent(int id)
        {
            var content = _db.Contents.FirstOrDefault(m => m.Id == id);
            return View(content);
        }

        [HttpGet("contents/search")]
        public IActionResult Search(string text, int page = 1)
        {
            ViewData["SearchContent"] = text;
            //use query from text 
            var query = from x in _db.Contents select x;
            if (!string.IsNullOrEmpty(text))
            {
                query = query.Where(x => x.Title.Contains(text) || x.Author.Contains(text));
            }

            //pagination
            const int pageSize = 6;
            if (page < 1) page = 1;

            int count = query.Count();
            var pager = new Pager(count, page, pageSize);
            int skip = (page - 1) * pageSize;
            var data = query.Skip(skip).Take(pager.PageSize).ToList();

            this.ViewBag.Pager = pager; 
            return View(data);
        }
    }
}