using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_213lab
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;
        // These are all private for encapsulation, and to hide the data.

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }
        // These are the properties, and they are what provide the indirect access to the fields above in other lines of code.

        public Person(int id, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColor = favoriteColor;
            this.isWorking = isWorking;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "ID: " + id + "\n" + "First Name: " + firstName + "\n" + "Last Name: " + lastName + "\n" + "Favorite Color: " + favoriteColor + "\n" + "Age: " + age + "\n" + "Is working: " + isWorking;

            return formatted;
        }
        
        public string DisplayPersonInfo()
        {
            string personInfo = "";

            personInfo += "Name = " + firstName + " " + lastName;

            return personInfo;
        }
        
        public string PersonId()
        {
            string displayed = "";

            displayed += id + ": " + firstName + " " + lastName + "'s favorite color is " + favoriteColor;

            return displayed;
        }

        public void ChangeFavoriteColor()
        {
            favoriteColor = "White";
        }

        public string GetAgeInTenYears()
        {
            int newAge = age + 10;
            string agedUp = firstName + " " + lastName + "'s Age in 10 years is: " + newAge;
            return agedUp;
        } 
    }
}
