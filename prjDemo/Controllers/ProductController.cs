using Microsoft.AspNetCore.Mvc;
using prjDemo.Models;
using prjDemo.ViewModels;
using System.Configuration;

namespace prjDemo.Controllers
{
    public class ProductController : Controller
    {
        public IWebHostEnvironment _eviroment;
        public ProductController(IWebHostEnvironment p)
        {
            _eviroment = p;
        }

        public IActionResult List(CKeywordViewModel vm)
        {
            dbDemoContext db = new dbDemoContext();
            string keyword = vm.txtKeyword;
            IEnumerable<TProduct> datas = null;
            if (keyword == null)
                datas = from c in db.TProducts
                        select c;
            else
                datas = db.TProducts.Where(c=>c.FName.Contains(keyword)).ToList();
            List<CProductViewModel> list = new List<CProductViewModel>();
            foreach (var d in datas)
            {
                CProductViewModel v = new CProductViewModel();
                v.Product = d;
                list.Add(v);
            }

            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TProduct p)
        {
            dbDemoContext db = new dbDemoContext();
            db.TProducts.Add(p);
            db.SaveChanges();

            return RedirectToAction("List");
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                dbDemoContext db = new dbDemoContext();
                TProduct prod = db.TProducts.FirstOrDefault(t => t.FId == id);
                if (prod != null)
                {
                    db.TProducts.Remove(prod);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("List");
        }

        public ActionResult Edit(int? id)
        {
            dbDemoContext db = new dbDemoContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FId == id);
            CProductViewModel vm = new CProductViewModel();
            vm.Product = prod;

            return View(vm);
        }
        [HttpPost]
        public ActionResult Edit(CProductViewModel vm)
        {

            dbDemoContext db = new dbDemoContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FId == vm.FId);
            if (prod != null)
            {

                prod.FName = vm.FName;
                prod.FQty = vm.FQty;
                prod.FPrice = vm.FPrice;
                prod.FCost = vm.FCost;
                db.SaveChanges();
            }

            return RedirectToAction("List");
        }

    }
}
