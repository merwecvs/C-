using System.ComponentModel.DataAnnotations;

namespace SotaApp.Data{
    public class Musteri{
        [Key]
        public int MusteriId {get;set;}
        public string? MusteriAdi{get;set;}
        public string? MusteriSoyad{get;set;}
        public string? Mail{get;set;}
        public int Telefon{get;set;}
    }
}