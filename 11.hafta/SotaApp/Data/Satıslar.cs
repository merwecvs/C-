using System.ComponentModel.DataAnnotations;

namespace SotaApp.Data{
    public class Satis{
        [Key]
        public int SatisId{get;set;}
        public int UrunId{get;set;}
        public Urun Urun{get;set;} = null!;
        public int MusteriId{get;set;}
        public Musteri Musteri{get;set;} = null!;
        public DateTime SatisTarihi{get;set;}
    }
}