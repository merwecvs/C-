using System;
using System.Collections.Generic;

class Ogrenci{
    public string Ad {get; set; }
    public int Yas {get; set; }
}

class Program {
    static void Main(){
        List<Ogrenci> ogrenciler = new List<Ogrenci> {
            new Ogrenci {Ad = "Merve", Yas = 20},
            new Ogrenci {Ad = "Yiğit", Yas = 18},
            new Ogrenci {Ad = "Murathan", Yas = 22},
            new Ogrenci {Ad = "Rümeysa", Yas = 15},
            new Ogrenci {Ad = "Neslihan", Yas = 23}
        };
        var filtrele = ogrenciler.Where(o =>o.Yas >18).ToList();
        foreach(var Ogrenci in filtrele){
            Console.WriteLine(Ogrenci.Ad + "-" + Ogrenci.Yas);
        }
    }
}