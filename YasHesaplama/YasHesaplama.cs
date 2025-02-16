using System;
class Yas{
    static void Main(){
        Console.Write("Doğum Yılınızı Giriniz:");
        int yilyas = Convert.ToInt32(Console.ReadLine());

        int yil = DateTime.Now.Year;
        int yas = yil-yilyas;

        Console.WriteLine($"Senin Yaşın: {yas}");
    }
}