using System;
class Program{
    static void Main(){
        int[] sayi = new int [5];
        Console.Write("Lütfen 1.Sayıyı Giriniz: ");
        sayi [0] = int.Parse(Console.ReadLine());
        Console.Write("Lütfen 2.Sayıyı Giriniz: ");
        sayi [1] = int.Parse(Console.ReadLine());
        Console.Write("Lütfen 3.Sayıyı Giriniz: ");
        sayi [2] = int.Parse(Console.ReadLine());
        Console.Write("Lütfen 4.Sayıyı Giriniz: ");
        sayi [3] = int.Parse(Console.ReadLine());
        Console.Write("Lütfen 5.Sayıyı Giriniz: ");
        sayi [4] = int.Parse(Console.ReadLine());

        Helper.FindMinMax(sayi, out int min, out int max);
        Console.WriteLine($"En Küçük Tam Sayı: {min}");
        Console.WriteLine($"En Küçük Tam Sayı: {max}");
    }
}