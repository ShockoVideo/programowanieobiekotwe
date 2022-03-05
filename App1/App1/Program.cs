using System;

namespace App1
{
    class Program
    {
        public static void Main()
        {
            Fraction a = new Fraction(2, 6);
            Fraction b = new Fraction();
            Fraction c = new Fraction(a);

            Fraction d = a + b;

            Console.WriteLine($"{d}");
        }
    }
}
