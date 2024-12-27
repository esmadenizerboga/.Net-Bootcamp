using System.ComponentModel.DataAnnotations;

namespace FormApp.Models{


    public class Product{

        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Gerekli bir alan!")]
        [Display(Name = "Ürün Adı")]
        public string? Name { get; set; } 

        [Required]
        [Range(0,1000000)]
        [Display(Name = "Ürün Fiyat")]
        public decimal? Price { get; set; }
        

        [Display(Name = "Ürün Görseli")]
        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Ürün Kategorisi")]
        public int CategoryId { get; set; }
    }
}