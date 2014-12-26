using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        private string firstName { get; set; }
        private string middleName { get; set; }
        private string lastName { get; set; }
        public Person(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person()
        {
            
        }

        public string FullName()
        {
           return firstName + " " + middleName + " " + lastName;
        }
        public string GetReverseName()
        {
            char[] cArray = FullName().ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;            
        }
    }
}
