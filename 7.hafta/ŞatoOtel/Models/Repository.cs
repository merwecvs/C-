using ŞatoOtel.Models;

public class Repository{

    private static readonly List<Oda> _oda = new();

    static Repository(){
        _oda = new List<Oda>(){
            new Oda() {Id = 1, Title = "Deniz Manzaralı Deluxe Oda", Description = "Geniş balkonlu, deniz manzaralı konforlu bir oda.", Image = "../img/1.jpg", Capacity= "2 Kişi", View="Deniz", BedType="Çift Kişik"},
            new Oda(){Id = 2, Title="Standart Tek Kişilik Oda", Description="Doğa ile iç içe, ekonomik bir konaklama seçeneği.",Image="../img/11.jpg", Capacity="2 Kişi", View="Şehir", BedType="İki Tek Kişilik"},
            new Oda(){Id=3, Image="../img/13.jpg", Title="Aile Odası", Description="Geniş aileler için ideal, 4 kişilik konaklama.", Capacity="4 Kişi", View="Şehir", BedType="İki Tek Kişilik, Bir Çift Kişilik"},
            new Oda(){Id=4, Image="../img/12.jpg", Title="Jakuzili Kral Dairesi", Description="Jakuzili, ultra lüks süit odamız özel konuklarımız için.", Capacity="2 Kişi", View="Deniz", BedType="Çift Kişilik"}
        };
    }

    public static Oda? GetById(int id){
        return _oda.FirstOrDefault(o=>o.Id == id);
    }
}