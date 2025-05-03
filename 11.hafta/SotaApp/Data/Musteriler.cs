using System.ComponentModel.DataAnnotations;

namespace SotaApp.Data{
    public class Musteri{
        [Key]
        public int MusteriId {get;set;}
        public string? MusteriAdi{get;set;}
        public string? MusteriSoyad{get;set;}
        public string AdSoyad{
            get{
                return this.MusteriAdi + " " + this.MusteriSoyad;
            }
        }
        public string? Mail{get;set;}
        public string? Telefon{get;set;}
        public ICollection<Satis>Satis{get;set;} = new List<Satis>(); 
    }
}