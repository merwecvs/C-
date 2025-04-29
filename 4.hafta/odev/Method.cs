using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

class Helper {
    public static async Task BeklemeMetodu(){
        await Task.Delay(3000);
        Console.WriteLine("İşlem devam ediyor...");
    }

    public static List<int> FiltreleTekSayilar(List<int> sayilar){
        return sayilar.Where(sayi => sayi % 2 !=0).ToList();
    }

    public static Func<string, string, string> birlestir =(s1,s2) => s1 + " " + s2;

    public static Action veriKaydet = () => Console.WriteLine("Veri Kaydedildi.");

    public static bool Uzunluk(string kelime){
        return kelime.Length>5;
    }
    
    public static void İkiKatinaCikar(ref int sayi){
        sayi *= 2;
    }

    public static int Topla(params int[] sayilar){
        int toplam = 0;
        foreach (int sayi in sayilar){
            toplam += sayi;
        }
        return toplam;
    }

    public static void SelamVer(){
        Console.Write("Lütfen Adınızı Giriniz:");
        string isim = Console.ReadLine();
        Console.WriteLine($"Merhaba, {isim}! Hoşgeldiniz.");
    }

    public static void SayilariCarp(){
        Console.Write("Birinci Sayıyı Giriniz:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci Sayıyı Giriniz:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        int carpim = sayi1*sayi2;
        Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {carpim}");
    }

    public static void SayilariCarpD(int sayi1, int sayi2){
        int carpim = sayi1 * sayi2;
        Console.WriteLine($"Sonuç (int): {sayi1} * {sayi2} = {carpim}");
    }
    public static void SayilariCarpD(double sayi1, double sayi2){
        double carpim = sayi1 * sayi2;
        Console.WriteLine($"Sonuç (int): {sayi1} * {sayi2} = {carpim}");
    }
    
    public static void KelimeyiTersCevir(string kelime){
        char[] kelimeDizisi = kelime.ToCharArray();
        Array.Reverse(kelimeDizisi);
        string tersKelime = new string(kelimeDizisi);
        Console.WriteLine($"Ters Çevrilmiş Kelime: {tersKelime}");
    }

}

