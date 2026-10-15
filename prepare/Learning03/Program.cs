using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3, 4);
        Fraction frac4 = new Fraction(1, 3);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());






        Fraction fraction = new Fraction();
        Random random = new Random();

        for (int count = 1; count <= 20; count += 1)
        {
            int top = random.Next(1, 100);
            int bottom = random.Next(1, 100);
            fraction.SetTop(top);
            fraction.SetBottom(bottom);
            Console.WriteLine($"Fraction Number {count}: Fraction String: {fraction.GetFractionString()} Decimal Number: {fraction.GetDecimalValue()}");
        }

        
    }
}