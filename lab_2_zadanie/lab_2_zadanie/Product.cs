using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    public class Product : IThing
    {
        private string name;

        public Product()
        {

        }

        public Product(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }

        public void Print(string prefix)
        {
            Console.WriteLine(prefix);
        }
    }
}
