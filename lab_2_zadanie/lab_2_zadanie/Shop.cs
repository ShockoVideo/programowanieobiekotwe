using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie
{
    public class Shop
    {
        private string name;
        private Person[] people;
        private Product[] products;
        public string Name { get => name; set =>name = value; }


        public Shop(string name, Person[]people, Product[] products)
        {
            this.people = people;
            this.products = products;


            Name = name;
        
        
        }


        public void Print()
        {
            Console.WriteLine("Shop: " + Name);
            Console.WriteLine("-- People: --");
            foreach(Person person in people)
            {
                  Console.WriteLine("Seller: " + person.Name + "(" + person.Age + "y.o.)");
                  Console.WriteLine("Buyer: " + person.Name + "(" + person.Age + "y.o.)");
                  if (products.Length != 0)
                  {
                      Console.WriteLine("-- Products: --");
                  }   
            }
        }

    }


}
