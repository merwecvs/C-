using System;
class program {
    static void Main(){
        Console.Write("Birinci Sayıyı Giriniz:");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci Sayıyı Giriniz:");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Sonuçlar:");
        Console.WriteLine($"Toplama: {sayi1 + sayi2}");
        Console.WriteLine($"Çıkarma: {sayi1 - sayi2}");
        Console.WriteLine($"Çarpma: {sayi1 * sayi2}");
        if (sayi2!=0)
            Console.WriteLine($"Bölme: {sayi1 / sayi2}");
        else
            Console.WriteLine("Bir sayı 0'a bölünemez.");
    }
}