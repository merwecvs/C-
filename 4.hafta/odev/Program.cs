using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;

class Program{
    static async Task Main(){
        Console.WriteLine("İşlem başlatıldı...");
        await Helper.BeklemeMetodu();
        Console.WriteLine("İşlem Tamamlandı.");
   
        List<int> sayilar = new List<int> {1,2,3,4,5,6,7,8,9,10};
        List<int> tekSayilar = Helper.FiltreleTekSayilar(sayilar);

        Console.WriteLine("Tek sayılar:" + string.Join(",", tekSayilar));

        string sonuc = Helper.birlestir("Merhaba","Dünya");
        Console.WriteLine(sonuc);

        Helper.veriKaydet();

        Console.Write("Bir Kelime Giriniz:");
        string kelime = Console.ReadLine();
        Predicate<string> uzunMu = Helper.Uzunluk;
        if (uzunMu(kelime)){
            Console.WriteLine($"{kelime} kelimesi 5 harften uzundur.");
        }
        else{
            Console.WriteLine($"{kelime} kelimesi 5 harften kısa veya eşittir.");
        }


        int deger = 10;
        Console.WriteLine("Önce:" + deger);
        Helper.İkiKatinaCikar(ref deger);
        Console.WriteLine("Sonra:" + deger);

        int toplam = Helper.Topla(10,20,30,40,50);
        Console.WriteLine("Toplam: " + toplam);

        Helper.SelamVer();

        Helper.SayilariCarp();

        Console.Write("Birinci Sayıyı Giriniz:");
        string input1 = Console.ReadLine();
        Console.Write("İkinci Sayıyı Giriniz:");
        string input2 = Console.ReadLine();
        if (int.TryParse(input1,out int sayi1) && int.TryParse(input2, out int sayi2)){
            Helper.SayilariCarpD(sayi1, sayi2);
        }
        else if (double.TryParse(input1, out double sayi1Double) && int.TryParse(input2, out int sayi2Double)){
            Helper.SayilariCarpD(sayi1Double, sayi2Double);
        }
        else{
            Console.WriteLine("Geçersiz İşlem Girdiniz.");
        }

        Console.Write("Bir Kelime Giriniz:");
        string kelime1 = Console.ReadLine();
        Helper.KelimeyiTersCevir(kelime1);
        
    } 

}