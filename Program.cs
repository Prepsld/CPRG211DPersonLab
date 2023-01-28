using CPRG211DPersonLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            //SO THESE ARE PROBABLY REALLY JANKY, BUT I SERIOUSLY COULDNT THINK OF ANOTHER WAY TO DOTHEM. 
            int youngest = 100;
            string youngPerson =""; 
            foreach (Person person in people)
            {
                if (person.Age < youngest) 
                {
                    youngest = person.Age;
                    youngPerson = person.FirstName;
                }
            }
            Console.WriteLine("The youngest person is: " + youngPerson);
            // Basically im making a int for the base age, starting at 100 for young and 0 for old. then running a loop through the list and changing that old/young variable
            // to whatever matches the oldest/youngest person, and then assigning their first name to a new variable. OUTSIDE OF THE LOOP I then print the finished loop's variable... I think
            int oldest = 0;
            string oldPerson = "";
            foreach (Person person in people)
            {
                if (person.Age > oldest)
                {
                    oldest = person.Age;
                    oldPerson = person.FirstName;
                }
            }
            Console.WriteLine("The oldest person is: " + oldPerson);
            //DONT YOU DARE JUDGE ME NICK IM TRYING MY BEST 

            // This is my code for printing people who's name starts with the letter "M". 
            foreach (Person person in people)
            {
                if (person.FirstName.Substring(0,1) == "M")
                {
                    string nameM = person.ToString();
                    Console.WriteLine(nameM);
                }
            }
            // I can really just copy this loop to find people who have "Blue" as their favorite color
            foreach (Person person in people)
            {
                if (person.FavoriteColor == "Blue")
                {
                    string blue = person.ToString();
                    Console.WriteLine(blue);
                }
            }

//This  was a neat little tip I got from a friend, it will keep the console open until you hit enter if I recall to close it. No need to flag a specific line to pause the program!
            Console.ReadLine();

        }
    }
}