using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] data = input.Split().ToArray();

                Person person = new Person();

                person.Name = data[0];
                person.ID = int.Parse(data[1]);
                person.Age = int.Parse(data[2]);

                
                people.Add(person);

                input = Console.ReadLine();
            }
            foreach (var person in people.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public int Age { get; set; }
        }
    }
}
