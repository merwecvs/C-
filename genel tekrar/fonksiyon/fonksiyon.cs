public class Helper{
    public static void FindMinMax(int []sayi, out int min, out int max){
        min = sayi[0];
        max = sayi[0];

        foreach (int say in sayi){
            if (say < min)
                min = say;
            if (say > max)
                max = say;
        }
    }
}