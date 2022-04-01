using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    public class Person : IThing
    {
        private string name;
        private int age;

        public Person()
        {

        }
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void Print(string prefix)
        {
            Console.WriteLine(prefix);
        }

    }
}
