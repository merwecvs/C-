using ŞatoOtel.Models;
using Microsoft.AspNetCore.Mvc;

namespace ŞatoOtel.Controllers{
    public class OdalarController: Controller{
        public IActionResult Odalar(){
            var oda = new List<Oda>(){
                new Oda() {Id = 1, Title = "Deniz Manzaralı Deluxe Oda", Description = "Geniş balkonlu, deniz manzaralı konforlu bir oda.", Image = "../img/1.jpg", Capacity= "2 Kişi", View="Deniz", BedType="Çift Kişik"},
                new Oda(){Id = 2, Title="Standart Tek Kişilik Oda", Description="Doğa ile iç içe, ekonomik bir konaklama seçeneği.",Image="../img/11.jpg", Capacity="2 Kişi", View="Şehir", BedType="İki Tek Kişilik"},
                new Oda(){Id=3, Image="../img/13.jpg", Title="Aile Odası", Description="Geniş aileler için ideal, 4 kişilik konaklama.", Capacity="4 Kişi", View="Şehir", BedType="İki Tek Kişilik, Bir Çift Kişilik"},
                new Oda(){Id=4, Image="../img/12.jpg", Title="Jakuzili Kral Dairesi", Description="Jakuzili, ultra lüks süit odamız özel konuklarımız için.", Capacity="2 Kişi", View="Deniz", BedType="Çift Kişilik"}
            };
            return View(oda);
        }
    public IActionResult Hizmetler(){
        var hizmetler = new List<Odalar>(){
            new Odalar() {Id = 1, Title = "🏨Konforlu Konaklama:", Description = "Şık ve modern tasarıma sahip odalarımızda konfor ve estetiği bir arada yaşayın. Geniş yataklarımız, yüksek kaliteli nevresimlerimiz ve huzur veren atmosferimizle rahat bir uyku deneyimi sunuyoruz. Ayrıca, odalarımızda klima, televizyon, mini bar ve ücretsiz Wi-Fi gibi olanaklarla evinizdeki konforu aratmayacak bir konaklama sizi bekliyor.", Image= "../img/4.jpg"},
            new Odalar() {Id = 2, Title = "🍽️ Restoran & Kafe: ", Description = "Gastronomi tutkunları için özel olarak hazırlanmış menülerimizle hem yerel hem de uluslararası lezzetleri deneyimleyin. Şeflerimizin özenle hazırladığı kahvaltılar, öğle ve akşam yemekleriyle tatilinize unutulmaz bir lezzet katıyoruz. Ferah kafe alanımızda, özel kahve çeşitleri ve tatlılarla keyifli vakit geçirebilirsiniz.", Image="6.jpg"},
            new Odalar() {Id = 3, Title = "🏖️Havuz & Plaj:", Description = "Açık ve kapalı yüzme havuzlarımız, yüzme keyfini dört mevsim yaşamanıza olanak tanıyor. Güneşlenme terasımızda dinlenebilir, özel plajımızda ise masmavi denizin tadını çıkarabilirsiniz. Plajımızda şezlong, şemsiye ve havlu hizmetleriyle konforlu bir deneyim yaşamanız için her şey düşünüldü.", Image= "9.jpg"},
            new Odalar() {Id = 4, Title = "💪Spor Salonu:", Description = "Sağlıklı ve enerjik kalmak isteyen misafirlerimiz için modern ekipmanlarla donatılmış spor salonumuz hizmetinizde. Kardiyo aletleri, ağırlık istasyonları ve esneme alanlarıyla her seviyeye uygun egzersiz imkanları sunuyoruz. Profesyonel antrenörlerimizden destek alabilir, tatiliniz boyunca formunuzu koruyabilirsiniz.", Image = "7.jpg"},
            new Odalar() {Id = 5, Title = "🧖‍♀️Spa & Masaj:", Description = "Zihninizi ve bedeninizi tazelemek için profesyonel terapistlerimiz tarafından uygulanan rahatlatıcı masajlar ve bakım hizmetleriyle kendinizi yenileyin. Aromaterapi masajı, sıcak taş terapisi ve cilt bakımları ile kendinize özel bir mola verin. Spa merkezimizde huzur dolu bir atmosferde gevşeyerek tüm yorgunluğunuzu atabilirsiniz.", Image= "5.jpg"},
            new Odalar() {Id = 6, Title = "🔥Sauna ve Buhar Odası:", Description = "Kaslarınızı gevşetmek ve toksinlerden arınmak için özel olarak tasarlanmış sauna ve buhar odalarımızda rahatlayın. Yüksek sıcaklığın ve nemin birleşimiyle cildinizin yenilendiğini hissedecek, rahatlatıcı bir deneyim yaşayacaksınız. Günün stresini geride bırakmak ve zinde hissetmek için mükemmel bir seçenek!", Image= "3.jpg"}
        };
        return View(hizmetler);
    }


    }
}