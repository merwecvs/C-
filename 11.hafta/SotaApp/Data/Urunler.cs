using System.ComponentModel.DataAnnotations;

namespace SotaApp.Data{
    public class Urun{
        [Key]
        public int UrunId{get;set;}
        public string? UrunAdi{get;set;}
        public int Stok{get;set;}
        public decimal Fiyat{get;set;}

    }
}