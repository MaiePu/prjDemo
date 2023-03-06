using Microsoft.AspNetCore.Mvc;

namespace prjDemo.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
