using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace _53_MVC_UrunYonetimSistemi.Models
{
    public class Product
    {
        private decimal _price;
        private static int _id = 0;

        [Required(ErrorMessage = "Id Boş Geçilemez!")]
        [DisplayName("Ürün Id:")]
        [Key]
        public int Id { get; private set; }

        [Required(ErrorMessage = "Ürün Adı Boş Geçilemez!")]
        [DisplayName("Ürün Adı:")]
        [StringLength(50)]
        public string Name { get; set; }

        public bool Status { get; set; }

        [Required(ErrorMessage = "Fiyat Boş Geçilemez!")]
        [DisplayName("Ürün Fiyatı:")]
        [Range(0, double.MaxValue, ErrorMessage = "Fiyat negatif olamaz.")]
        public decimal Price 
        { 
            get { return _price; }
            set
            { _price = value;  }
        }

        public List<Category>? Categorys { get; set; } = new List<Category>() 
        {
            new Category{Id=1, Name="Elektronik"},
            new Category{Id=2, Name="Kozmetik"},
            new Category{Id=3, Name="Giyim"},
            new Category{Id=4, Name="Gıda"}
        };
        public int? CategoryKey { get; set; }

        public Product()
        {
            Id += _id; 
        }
    }
}
