using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demostrate strin intern if used
            string myString = "myString";
            Console.WriteLine(myString);
            Console.WriteLine(string.IsInterned(myString) != null ? true : false);

            //Demostrate strin intern never used.
            //By default, when an assembly is loaded, the CLR interns all of the literal strings
            //described in the assembly’s metadata
            Console.WriteLine(string.IsInterned("myStringNeverUsed") != null ? true : false);

            //Demostrate strin intern never used. Compose run time
            string myStringRT = new StringBuilder().Append("myString").Append(DateTime.Now).ToString();
            Console.WriteLine(string.IsInterned(myStringRT) != null ? true : false);

            //Demostrate string intern request
            string.Intern(myStringRT);
            Console.WriteLine(string.IsInterned(myStringRT) != null ? true : false);

            String s1 = "Hello";
            String s2 = "Hello";
            Console.WriteLine(Object.ReferenceEquals(s1, s2)); // Should be 'False'

            s1 = StringExample.Intern(s1);
            s2 = StringExample.Intern(s2);
            Console.WriteLine(Object.ReferenceEquals(s1, s2)); // 'True'
        }
    }
}
