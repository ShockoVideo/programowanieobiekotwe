using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Fraction
    {
        private int nominator { get; }

        private int denominator { get; }


        public Fraction()
        {
            this.nominator = 1;
            this.denominator = 2;

        }

        public Fraction(int nominator, int denominator)
        {
            this.nominator = nominator;
            this.denominator = denominator;


        }

        public Fraction(Fraction previousFraction)
        {

            this.nominator = previousFraction.nominator;
            this.denominator = previousFraction.denominator;

        }


        public override string ToString()
        {
            return "licznik " + nominator.ToString() + " i mianownik " + denominator.ToString();
        }

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.nominator * b.denominator + b.nominator * a.denominator, a.denominator * b.denominator);






    }

    
  

 


}
