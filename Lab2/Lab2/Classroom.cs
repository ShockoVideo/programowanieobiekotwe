using System;


namespace Lab2
{
	public class Classroom
	{
		private string name;
		private Person[] persons;

		public string Name { get => name; set => name = value; }

		public Classroom(string name, Person[] persons)
        {
			this.Name = name;
			this.persons = persons;
        }

        public override string ToString()
        {
            return "Classroom:" + Name + persons ;
        }

    }
}
