using System;

namespace Lab2
{

	public class Person
	{
		private string name;
		private int age;
		
		protected string Name { get=> name; set =>name; }
		protected int	Age { get=> age; set=> age = value; }
		
		public Person(string name, int age)
		{
			this.name = name;
			this.age = age;

		}

        public override string ToString()
        {
            return "Name = " + Name + ",Age = " Age;
        }
    }

}
