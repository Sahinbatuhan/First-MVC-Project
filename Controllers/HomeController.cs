using _53_MVC_UrunYonetimSistemi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _53_MVC_UrunYonetimSistemi.Controllers
{
    public class HomeController : Controller
    {
        /*Ürün Yönetim Sistemi
             *>>Ürün Ekleme Sayfası
             *Category (Id, Name)
             *Product 
             *  -Ürün Adı (Zorunlu, Max 50 Karakter)
             *  -Fiyat (Zorunlu, 0 dan büyük olmalı)
             *  -Kategoriler (Dropdown ile kategori seçmeli)
             *  -Durumu (Checkbox)
             *>>Ürün Listeleme Sayfası
             *  -Mevcut ürünlerin listelendiği sayfa
             *  -Ürün durumu aktif ise yeşil, ürün durumu pasif ise kırmızı göster.
             *  -Düzenle ve sil buton veya link
             *  -Toplam ürün sayısı.
             *>>Ürün Güncelleme ve Silme.
             */


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
