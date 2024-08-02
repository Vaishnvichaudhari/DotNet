using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    //Query stringExample
    //url=/Default/Index/10?a=10&b=20
    //url=/Default/Index/10?&b=20
    //url=/Default/Index/10?a=10
    //url=/Default/Index/10?a=10&b=20&c=30
    //url=/Default/Index/10?a=10&c=30
    public class DefaultController : Controller
    {
        public IActionResult Index(int? id, int a=1 ,int b=2 , int c=3)
        {
            //if (id == null)
            //    return NotFound();
            ViewBag.id = id;
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;  
            
            return View();
        }
        public IActionResult View1() //View which have different name and different method-- return Index1 in return view
        {
            
            return View("Index1");
        }
        public IActionResult View2() //Using Razor view do not use layout --layout==null
        {

            return View();
        }
        public IActionResult View3() // default layout 
        {

            return View();
        }
        public IActionResult View4() //use a specific layout
        {

            return View();
        }
        public IActionResult View5() //
        {

            return View();
        }
    }
}
