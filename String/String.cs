using System;
class String {
    static void Main(){
        Console.Write("Bir Cümle Giriniz:");
        string cumle = Console.ReadLine();
        Console.WriteLine("String Metodları Uygulaması:");
        Console.WriteLine($"Büyük Harf: {cumle.ToUpper()}");
        Console.WriteLine($"Küçük Harf: {cumle.ToLower()}");
        Console.WriteLine($"Kaç Karakter Var: {cumle.Length}");
        Console.WriteLine($"İlk Harf: {cumle?[0]}");
        Console.WriteLine($"Son Harf: Son harf: {cumle?[^1]}");
        Console.WriteLine($"Boşlukları Kaldırılmış: {cumle.Trim()}");
    }
}