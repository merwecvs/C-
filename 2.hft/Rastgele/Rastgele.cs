using System;
class Rastgele {
    static void Main(){
        Random rastgele = new Random();
        int sayi = rastgele.Next(1,101);
        Console.WriteLine($"Üretilen Rastgele Sayı: {sayi}");
    }
}