using CPRG211DPersonLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_213lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Person person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);

            string ginaInfo = person2.PersonId();
            Console.WriteLine(ginaInfo);

            string mikeInfo = person3.ToString();
            Console.WriteLine(mikeInfo);

            person1.ChangeFavoriteColor();
            Console.WriteLine(person1.PersonId());

            string newAge = person4.GetAgeInTenYears();
            Console.WriteLine(newAge);

            Relation relation1 = new Relation("Sister", person2, "Sister", person4);
            Relation relation2 = new Relation("Brother", person1, "Brother", person3);
            Console.WriteLine(relation1);
            Console.WriteLine(relation2);

            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            int sum = 0;
            foreach (Person person in people)
            {
                sum += person.Age;
            }
            double average = sum / (double) people.Count;
            Console.WriteLine("Average age is: " + average);

            Console.ReadLine();

        }
    }
}



/* g.	Add all the Person objects to a list, and then use the list to display the following:
•	The average age of the people in the list
•	The youngest person and the oldest person
•	The names of the people whose first names start with M
•	The person information of the person that likes the colour blue
*/