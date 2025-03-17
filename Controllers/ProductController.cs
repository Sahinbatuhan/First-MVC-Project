using _53_MVC_UrunYonetimSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace _53_MVC_UrunYonetimSistemi.Controllers
{
    public class ProductController : Controller
    {
        public static IList<Product> products = new List<Product>() { new Product { Name = "TV", Price = 100, Status = true } };
        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                var existingProduct = products.FirstOrDefault(p => p.Name == model.Name);

                if (existingProduct != null)
                {
                   
                    existingProduct.Name = model.Name;
                    existingProduct.Price = model.Price;
                    existingProduct.CategoryKey = model.CategoryKey;
                    existingProduct.Status = model.Status;

                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Status = "Eklemek istediğiniz ürün zaten sistemde kayıtlı";
                    return View(model);
                    
                }
            }

            return View(model); 


            //if (ModelState.IsValid)
            //{
            //    products.Add(model);
            //    return Content($"Id:{model.Id} - Ürün Adı:{model.Name} Fiyatı:{model.Price} Kategori: {model.CategoryKey} Durum:{model.Status}");
            //}
            //return View(model);
        }

        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            products.Remove(product);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            var selectProduct = products.FirstOrDefault(x => x.Id == id);
            return View("Create",selectProduct);

        }
    }
}
