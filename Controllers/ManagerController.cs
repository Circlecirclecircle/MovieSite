using Microsoft.AspNetCore.Mvc;

namespace MovieSite.Controllers
{
    public class ManagerController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataForm()
        {
            return View();
        }

        public IActionResult AddSave()
        {
            return null;
        }

        public IActionResult EditSave()
        {
            return null;
        }

        public IActionResult DelteSave()
        {
            return null;
        }
    }
}