namespace GorevTakip.WebAPI.Models
{
    public class Gorev
    {
        public int Id { get; set; }
        
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public bool TamamlandiMi { get; set; }
    }
}
