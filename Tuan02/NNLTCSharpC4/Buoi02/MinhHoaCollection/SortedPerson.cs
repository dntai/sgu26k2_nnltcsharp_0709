using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLCS.BaiTap
{
    public class SortedPerson
    {
        static void Main(string[] args)
        {
            //create the SortedSet
            SortedSet<Person> people = new SortedSet<Person>(new PersonComparer());
            //add some random folks:
            Random rnd = new Random();
            for (int i = 1; i <= 25; i++)
            {
                //new person
                Person person = new Person();
                person.name = "Bob " + i.ToString();
                person.location = "Miami" + i.ToString();
                //random age
                int r = rnd.Next(1, 99);
                person.age = r;
                //add person to set
                people.Add(person);
            }
            //show our list:
            foreach (Person person in people)
            {
                Console.WriteLine(person.name + " - Age: " + person.age.ToString());
            }
            Console.ReadLine();
        }

        //create comparer
        internal class PersonComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                //first by age
                int result = x.age.CompareTo(y.age);
                //then name
                if (result == 0)
                    result = x.name.CompareTo(y.name);
                //a third sort
                if (result == 0)
                    result = x.location.CompareTo(y.location);
                return result;
            }
        }

        internal class Person
        {
            public string name { get; set; }
            public string location { get; set; }
            public int age { get; set; }
        }
    }
}
