using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    public class Buyer : Person
    {

        private List<Product> tasks = new List<Product>();

        public Buyer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        public void RemoweProduct(int index)
        {
            tasks.Remove(tasks[index]);


        }

        public void Print(string prefix)
        {
            Console.WriteLine(prefix);
        }
    }
}
