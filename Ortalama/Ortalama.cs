using System;
class Ortlama {
    static void Main(){
        Console.Write("Birinci Sayıyı Giriniz:");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci Sayıyı Giriniz:");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Üçüncü Sayıyı Giriniz:");
        double sayi3 = Convert.ToDouble(Console.ReadLine());

        double ort = (sayi1 + sayi2 + sayi3)/3;

        Console.WriteLine($"Girdiğiniz Sayıların Ortalaması: {ort}");
    }
}
