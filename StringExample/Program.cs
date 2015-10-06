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
            string s = new string("pippo".ToCharArray());
            if (s.ToUpperInvariant().Substring(10, 21).EndsWith("EXE")) {
                Console.Write("Ciao");
            }
            Console.ReadKey();
        }
    }
}
