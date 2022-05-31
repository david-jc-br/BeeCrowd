//Circle of Area Solution
using System;

class URI
{
    static void Main(string[] args)
    {
        double ray = double.Parse(Console.ReadLine());
        double area = 3.14159 * (ray * ray);
        Console.WriteLine($"A=" + area.ToString("0.0000"));
    }
}