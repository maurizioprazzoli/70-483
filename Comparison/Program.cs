using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = "Test string";
            object o1 = o;

            Console.WriteLine("o == o1 : {0}", o == o1);
            Console.WriteLine("o.Equals(o1) : {0}", o.Equals(o1));

            o1 = new string("Test string".ToCharArray());
            Console.WriteLine("o == o1 : {0}", o == o1);
            Console.WriteLine("o.Equals(o1) : {0}", o.Equals(o1));

            Console.ReadKey();
        }
    }
}
