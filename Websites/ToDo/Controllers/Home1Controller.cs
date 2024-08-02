using Microsoft.AspNetCore.Mvc;

namespace ToDo.Controllers
{
    public class Home1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult View1()  //View which have different name and different method-- return Index1 in return view
        {

            return View("Index1");
        }

        public IActionResult View2()  // No Default layout
        {

            return View();
        }
        public IActionResult View3()
        {

            return View();
        }

        public IActionResult View4()
        {

            return View();
        }

    }
}
