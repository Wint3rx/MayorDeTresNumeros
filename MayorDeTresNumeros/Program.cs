using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        double n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número");
        double n3 = Convert.ToDouble(Console.ReadLine());

        double mayor = ObMayor(n1, n2, n3);

        Console.WriteLine($"El mayor de los tres números es: {mayor}");
    }
    static double ObMayor(double a, double b, double c)
    {
        //Compara los números para encontrar el mayor
        if (a >= b && a >= c)
        {
            return a;
        }
        else if (b >= a && b >= c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}
