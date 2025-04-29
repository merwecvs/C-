using System;
class Program{
    static void Main(){
        Console.Write("Adınızı Giriniz: ");
        string ad = Console.ReadLine();
        Console.Write("Soyadınızı Giriniz: ");
        string soyad = Console.ReadLine();
        Console.Write("Yaşınızı Giriniz: ");
        int yas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Merhaba {ad} {soyad}, {yas} yaşındasınız. Hoşgeldiniz!");
    }
}
