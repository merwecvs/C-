using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models{
    public class Product{
        [Display( Name= "Ürün ID")]
        public int ProductId {get; set;}

        [Display(Name= "Ürün Adı")]
        [Required(ErrorMessage ="Ürün Adı Zorunludur.")]
        public string Name {get;  set;}

        [Display(Name= "Ürün Fiyatı")]
        [Range(0,100000, ErrorMessage ="Ürün Fiyatı 0 İle 100000 Arası Olmak Zorundadır.")]
        [Required(ErrorMessage ="Ürün Fiyatı Zorunludur.")]
        public decimal? Price {get; set;}

        [Display(Name= "Ürün Fotoğrafı")]
        [Required(ErrorMessage ="Ürün Fotoğrafı Zorunludur.")]
        public string Image {get; set;} = string.Empty;

        [Display(Name= "Ürün Stok")]
        [Range(0,1000, ErrorMessage ="Stok Miktarı 0 İle 100 Arası Olabilir.")]
        [Required(ErrorMessage ="Stok Bilgisi Zorunludur.")]
        public decimal? Stock {get; set;}

        public bool IsActive {get; set;}

        [Display(Name= "Ürün Kategorisi")]
        public int CategoryId {get; set;}
    }
}