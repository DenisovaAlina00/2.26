using System;
public class MainClass
{
   public static void Main(string[] args)
    {
        int n = 564;
        var p = n % 10;
        var x = (n - p) / 10 + (p * 100);
        Console.WriteLine("Трехзначное число равно ={0}", x);
        Console.ReadKey();
    }

}

