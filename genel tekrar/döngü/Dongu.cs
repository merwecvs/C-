using System;
class Program{
    static void Main(){
        Console.Write("Bir Sayı Giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int toplamfor = 0;
        for (int i = 1; i <= sayi; i++){
            toplamfor += i;
        }
        Console.WriteLine($"For Döngüsü İle Toplam: {toplamfor}");

        int toplamwhile = 0;
        int j = 1;
        while (j <= sayi){
            toplamwhile +=j;
            j++;
        } 
        Console.WriteLine($"While Döngüsü İle Toplam: {toplamwhile}");
    }
}

