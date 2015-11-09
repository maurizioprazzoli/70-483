using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTest
{
    class Program
    {
        
        // Define Enum with following:
        // Names:   [Prova1],[Prova2],[Prova3],[Prova4]
        // Values:  0       ,1       ,2       ,3

        internal enum ProvaFirtElementZero : int
        {
            Prova1, // 0
            Prova2, // 1
            Prova3, // 2
            Prova4  // 3
        }
        static void Main(string[] args)
        {
            ProvaFirtElementZero prova;
            prova = ProvaFirtElementZero.Prova4;


            Console.WriteLine(prova);               // "Prova4" (General format)
            Console.WriteLine(prova.ToString());    // "Prova4" (General format)
            Console.WriteLine(prova.ToString("G")); // "Prova4" (General format)
            Console.WriteLine(prova.ToString("D")); // "3" (Decimal format)
            Console.WriteLine(prova.ToString("X")); // "03" (Hex format)


            Int32 myValue = (Int32)prova;
            // Testing default value
            Int32 defaultValue = (Int32)default(ProvaFirtElementZero);
            Console.WriteLine("Default value: {0}", defaultValue);

            Console.WriteLine(System.Enum.Format(typeof(ProvaFirtElementZero), (Int32)3, "G"));

            Type enumType = prova.GetType();
            TypeCode enumTypeCode = prova.GetTypeCode();

            string s = System.Enum.GetName(typeof(ProvaFirtElementZero), 3);
            string[] s1 = System.Enum.GetNames(typeof(ProvaFirtElementZero));

            var s2 = System.Enum.GetValues(typeof(ProvaFirtElementZero));

            string sNotExist = System.Enum.GetName(typeof(ProvaFirtElementZero), -1);
            ProvaFirtElementZero notExist = (ProvaFirtElementZero)(-1);

            bool isExisting = Enum.IsDefined(typeof(ProvaFirtElementZero), -1);

            ProvaFirtElementZero notExist1 = (ProvaFirtElementZero)(-1);
            Enum.TryParse("Prova5", true, out notExist1);
            Console.WriteLine(notExist1);
            Enum.TryParse("Prova4", true, out notExist1);
            Console.WriteLine(notExist1);  

            Console.ReadKey();
        }
    }
}
