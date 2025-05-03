using System.ComponentModel.DataAnnotations;

namespace SotaApp.Data{
    public class Urun{
        [Key]
        public int UrunId{get;set;}
        public int? SaticiId{get;set;}
        public Satici Satici{get;set;} = null!; 
        public string? UrunAdi{get;set;}
        public int Stok{get;set;}
        public decimal Fiyat{get;set;}
        public ICollection<Satis>Satis{get;set;} = new List<Satis>(); 

    }
}