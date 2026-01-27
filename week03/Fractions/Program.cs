using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

    Fraction f1 = new Fraction();
    f1.GetFractionString();
    Console.WriteLine(f1.GetFractionString());

    f1.GetDecimalValue();
    Console.WriteLine(f1.GetDecimalValue());

    Fraction f2 = new Fraction(5);
    f2.GetFractionString();
    Console.WriteLine(f2.GetFractionString());

    f2.GetDecimalValue();
    Console.WriteLine(f2.GetDecimalValue());


    Fraction f3 = new Fraction(3, 4);
    f3.GetFractionString();
    Console.WriteLine(f3.GetFractionString());

    f1.GetDecimalValue();
    Console.WriteLine(f3.GetDecimalValue());

    Fraction f4 = new Fraction(1, 3);
    f4.GetFractionString();
    Console.WriteLine(f4.GetFractionString());

    f4.GetDecimalValue();
    Console.WriteLine(f4.GetDecimalValue());

    }


   
}

