using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Startup
    {
        public static void Main()
        {
            Person aPerson = new Person();

            Person aPerson2 = new Person("James", "Ruman");
            string fullName = aPerson2.FullName();
            string revName = aPerson2.GetReverseName();

            Console.WriteLine(fullName);
            Console.WriteLine(revName);

            Console.ReadKey();
        }
    }
}
