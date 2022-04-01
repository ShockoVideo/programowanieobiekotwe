using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    public class Fruit : Product
    {

        private int count;

        public int Count { get => count; set => count = value; }

        public Fruit (string name, int count)
        {
            Name = name;
            Count = count;
        }

        public void Print(string prefix)
        {
            Console.WriteLine(prefix);
        }
    }
}
