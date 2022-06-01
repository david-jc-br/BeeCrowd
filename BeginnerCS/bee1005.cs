//Averange 1 / Media Ponderada
using System;

class URI
{
    static void Main()
    {
        float a, b, media;
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());

        media = ((a * 3.5f) + (b * 7.5f)) / 11;

        Console.WriteLine("MEDIA = " + media.ToString("0.00000"));
    }
}