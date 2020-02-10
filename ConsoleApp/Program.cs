using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Fraction fraction = new Fraction(3, 5) { };
            Console.WriteLine(fraction.ToString());
           /* {
                Numerator = 3,
                Denominator = 5,
            };*/
           /* List<Fraction> fractions = new List<Fraction>
            {
                new Fraction() { Numerator =3, Denominator =4 },
                new Fraction() { Numerator =5, Denominator =6 },
                new Fraction() { Numerator =7, Denominator =8 },

            };*/
          
        }
    }
    class Fraction 
    {
        public int Numerator { get; } = 5;
        public int Denominator { get; } = 4;
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

    }
}
