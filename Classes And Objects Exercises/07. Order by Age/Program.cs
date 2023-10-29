using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personInfo = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] cmndArrs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = cmndArrs[0];
                string personID = cmndArrs[1];
                int age = int.Parse(cmndArrs[2]);

                Person person = new Person(name, personID, age);

                personInfo.Add(person);
            }

            List<Person> currList = personInfo.OrderBy(x => x.Age).ToList();

            foreach (Person person in currList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, string ID, int age)
        {
            this.Name = name;
            this.ID = ID;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}