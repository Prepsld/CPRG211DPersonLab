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

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

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

            formatted += "ID: " + id + "\n";
            formatted += "First Name: " + firstName + "\n";


            return formatted;
        }
    }
}



//public string ToString () { string formatted = ""; formatted += "ID:" + id + "\n"; formatted += "First Name:" + firstName +"\n"; return formatted;  }

//Due before start of next lab
//This WILL be graded
//10% of final grade will be labs

/* DisplayPersonInfo: accepts six person attributes and displays name=Firname and lastname
 * personId: names favorite color is favoritecolor
 * changefavoritecolour: changes persons favorite color to white
 * getageintenyears: gets the persons age after ten years
 * tostringmethod: displays all person object information as a list
 */


// Relation Class - skip this part for now