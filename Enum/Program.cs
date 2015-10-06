using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        
        internal enum Prova
        {
            Prova1,
            Prova2,
            Prova3 = 0,
            Prova4
        }
        static void Main(string[] args)
        {
            Prova prova;
            prova = Prova.Prova4;
            Console.WriteLine(prova); // "Blue" (General format)
            Console.WriteLine(prova.ToString()); // "Blue" (General format)
            Console.WriteLine(prova.ToString("G")); // "Blue" (General format)
            Console.WriteLine(prova.ToString("D")); // "3" (Decimal format)
            Console.WriteLine(prova.ToString("X")); // "03" (Hex format)

            Console.WriteLine(System.Enum.Format(typeof(Prova), (Int32)3, "G"));

            string s = System.Enum.GetName(typeof(Prova), 3);
            string[] s1 = System.Enum.GetNames(typeof(Prova));

            var s2 = System.Enum.GetValues(typeof(Prova));

            Console.ReadKey();

            Object a;
            a = 10;
            DateTime c;
            c = (DateTime)a;


        }
    }
}
