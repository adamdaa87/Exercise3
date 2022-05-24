using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    internal class PersonHandler
    {
        private List<Person> people;

        public PersonHandler()
        {
            people = new List<Person>();
        }

        public Person CreatePerson (string fname, string lname)
        {
            Person person = new Person(fname, lname);
            Console.WriteLine($"En person har skapats: {fname} {lname}.");
            return person;
        }

        public Person CreatePerson(string fname, string lname, double height, double weight, uint age) 
        { 
            Person person = new Person(fname, lname, height, weight, age);
            Console.WriteLine("En person har skapats:");
            Console.WriteLine($"Namn: {fname} {lname} längd: {height} cm, vikt: {weight} kg, ålder: {age} år gammal.");
                
            return person;
        }

        public void SetAge(Person pers, uint age)
        {
            pers.Age = age;
            Console.WriteLine($"{pers.FName} {pers.LName}: är {age} år gammal.");
        }

        public void SetHeightAndWeight(Person pers, double height, double weight)
        {
            pers.Height = height;
            pers.Weight = weight;
            Console.WriteLine($"{pers.FName} {pers.LName} är {height} cm och väger {weight} kg.");
        }
        public bool AddPerson(Person pers)
        {
            if(pers == null)
                return false;
            people.Add(pers);
            return true;    
        }

        public void DeletePersonAt(int index)
        {
            if (index > people.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("The index is out of the list's range");
            }
            else
            {
                people.RemoveAt(index);
            }

        }

        public Person GetPerson(int index)
        {
            if (!people.Any())
            {
                Console.WriteLine("The list is empty");
                return null;
            }
            else 
            { 
                return people[index];
            }
        }

        public string[] GetPeople()
        {
            if (!people.Any())
            {
                Console.WriteLine("The list is empty");
                return null;
            }
            else
            {
                string[] strInfoStrings = new string[people.Count];

                int i = 0;
                foreach (Person pers in people)
                {
                    strInfoStrings[i++] = pers.ToString();
                }
                return strInfoStrings;
            }
        }

        public void PrintOutPeople()
        {
           Console.ForegroundColor = ConsoleColor.DarkGreen;
           Console.WriteLine("----------------------------------------------");
           Console.WriteLine("{0, -10} {1, -10} {2, -5} {3, -5} {4, -5}",
                "Förnamn", "Efternamn", "Ålder", "Längd", "Vikt");
           Console.WriteLine("----------------------------------------------");
            
            string[] strInfo = GetPeople();
           
            foreach (string str in strInfo)
               Console.WriteLine(str);
           Console.ForegroundColor = ConsoleColor.White;
        }      
    }
}
