﻿using System;
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

            double average = Convert.ToDouble(person1.Age + person2.Age + person3.Age + person4.Age) / 4;

            Console.WriteLine(person2.PersonId());

            Console.WriteLine(person3.ToString());

            Console.WriteLine(person1.ChangeFavoriteColor());

            Console.WriteLine(person4.GetAgeInTenYears());

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