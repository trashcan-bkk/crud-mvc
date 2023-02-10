using System.Linq;
using crud_mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud_mvc.Controllers
{
    public class AccountController : Controller
    {
         [BindProperty]
        public Account account { get; set; }
        private readonly DatabaseContext _db;

        public AccountController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("account/login")]
        public IActionResult Login() //Login page
        {
            return View();
        }

        public IActionResult LoginAction()
        {
            var acc = LoginProcess(account.Username, account.Password);
            if (acc == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                HttpContext.Session.SetString("username", acc.Username);
                return RedirectToAction("Index", "Management");
            }
        }

        private Account LoginProcess(string username, string password)
        {
            var account = _db.Accouunts.SingleOrDefault(a => a.Username.Equals(username));
            if (account != null)
            {
                return account;
                //if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                //{
                //    return account;
                //}
            }
            return null;
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login");
        }
    }
}