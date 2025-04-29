using System.ComponentModel.DataAnnotations;

namespace SotaApp.Data{
    public class Satis{
        [Key]
        public int SatisId{get;set;}
        public int UrunId{get;set;}
        public int MusteriId{get;set;}
    }
}