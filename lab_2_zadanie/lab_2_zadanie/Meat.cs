using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    public class Meat : Product
    {
        private double weight;

        public Meat(string name, double weight)
        {
            Name = name;
            Weight = weight;

        }

        public double  Weight { get => weight; set => weight = value; }

        public void Print(string prefix)
        {
            Console.WriteLine(prefix);
        }
    }
}
