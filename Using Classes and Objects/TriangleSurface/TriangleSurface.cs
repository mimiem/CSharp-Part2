//Write methods that calculate the surface of a triangle by given:
//-Side and an altitude to it;
//-Three sides;
//-Two sides and an angle between them;
//Use System.Math.

using System;

class TriangleSurface
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculate the surface of a triangle by:");
        Console.WriteLine("1. Side and an altitude to it");
        Console.WriteLine("2. Three sides");
        Console.WriteLine("3. Two sides and an angle between them");
        Console.Write("Your choise is: ");
        int choise = int.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1:
                Console.Write("Side: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Altitude: ");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + SideAndAtitude(a, h));
                break;
            case 2:
                Console.Write("Side A: ");
                double a2 = double.Parse(Console.ReadLine());
                Console.Write("Side B: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Side C: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + ThreeSides(a2, b, c));
                break;
            case 3:
                Console.Write("Side A: ");
                double a3 = double.Parse(Console.ReadLine());
                Console.Write("Side B: ");
                double b3 = double.Parse(Console.ReadLine());
                Console.Write("Enter angle (in degrees): ");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + TwoSidesAndAngle(a3, b3, angle));
                break;
        }
    }
    static double SideAndAtitude(double a, double h)
    {
        return (a * h) / 2;
    }
    static double ThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    static double TwoSidesAndAngle(double a, double b, double angle)
    {
        return (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
    }
}

