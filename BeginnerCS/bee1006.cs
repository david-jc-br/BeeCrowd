//Averange 2 / Media Ponderada
using System;

class URI
{
    static void Main()
    {
        double a, b, c;
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());

        double media = ((a * 2) + (b * 3) + (c * 5)) / 10;

        Console.WriteLine("MEDIA = " + media.ToString("0.0"));
    }
}