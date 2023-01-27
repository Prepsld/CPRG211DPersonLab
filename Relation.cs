using CPRG_213lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    internal class Relation
    {
        private string person1Relation;
        private Person person1;

        private string person2Relation;
        private Person person2;

        public string Person1Relation { get { return person1Relation; } }
        public string Person2Relation { get { return person2Relation; } }

        public Person Person1 { get { return person1; } }
        public Person Person2 { get { return person2; } }

        public Relation(string person1Relation, Person person1, string person2Relation, Person person2)
        {
            this.person1Relation = person1Relation;
            this.person1 = person1;
            this.person2Relation = person2Relation;
            this.person2 = person2;
        }
        public override string ToString()
        {
            string formatted;
            formatted = Person1.FirstName + "is a " + Person1Relation + "\n";
            formatted += Person2.FirstName + "is a " + Person2Relation + "\n";
            return formatted;
        }
    }
}
