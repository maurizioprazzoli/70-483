﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class Program
    {
        //static void Main()
        //{

        //}
        static Int32 Main(string[] args)
        {
            //string s = new string("pippo".ToCharArray());
            //if (s.ToUpperInvariant().Substring(10, 21).EndsWith("EXE")) {
            //    Console.Write("Ciao");
            //}

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

            s1 = string.Intern(s1);
            s2 = string.Intern(s2);
            Console.WriteLine(Object.ReferenceEquals(s1, s2)); // 'True'

            Console.Write(s1[1]);

            //long error = 1000000 * 1000000; // Compile-time error (32-bit overflow)
            long trillion = 10000000000L * 1000000L; // Okay -- no overflow

            return 1;
        }
    }
}
