using System;

class Program{
    static void Main(){
        Console.Write("Bir Sayı Giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi<0)
        Console.WriteLine("Girilen Sayı Negatiftir.");
        else if (sayi>0)
        Console.WriteLine("Girilen Sayı Pozitiftir.");
        else 
        Console.WriteLine("Girilen Sayı 0'a eşittir.");
    }
}
