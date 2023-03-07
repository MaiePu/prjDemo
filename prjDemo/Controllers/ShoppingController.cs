using Microsoft.AspNetCore.Mvc;
using prjDemo.Models;
using prjDemo.ViewModels;

namespace prjDemo.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult List()
        {
            dbDemoContext db = new dbDemoContext();
            var datas = from c in db.TProducts
                        select c;
            return View(datas);
        }
        public ActionResult AddToCart()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddToCart(CAddToCartViewModel p)
        {
            dbDemoContext db = new dbDemoContext();


            return View();
        }
    }
}
