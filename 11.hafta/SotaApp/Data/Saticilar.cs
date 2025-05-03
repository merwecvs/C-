using System.ComponentModel.DataAnnotations;
namespace SotaApp.Data{
    public class Satici{
        [Key]
        public int SaticiId{get;set;}
        public string? SaticiAdi{get;set;}
        public string? SaticiSoyadi{get;set;}
        public string AdSoyad{
            get{
                return this.SaticiAdi + " " + this.SaticiSoyadi;
            }
        }
        public string? Mail{get;set;}
        public string? Telefon{get;set;}
        public DateTime BaslamaTarihi{get;set;}
        public ICollection<Urun>Urunler{get;set;} = new List<Urun>(); 
    }
}