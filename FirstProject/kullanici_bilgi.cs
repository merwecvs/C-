using System;
class user {
    static void Main() {
        Console.Write("Adınızı Giriniz:");
        string ad = Console.ReadLine();
        Console.Write("Soyadınızı Giriniz:");
        string soyad = Console.ReadLine();
        Console.Write("Yaşınızı Giriniz:");
        int yas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Yaşadığınız Şehri Giriniz:");
        string sehir = Console.ReadLine();
        Console.Write("Mesleğinizi Giriniz:");
        string meslek = Console.ReadLine();
        Console.WriteLine($"Adınız: {ad} {soyad}\nYaşınız: {yas}\nYaşadığınız Şehir: {sehir}\nMesleğiniz: {meslek}");
    }
}