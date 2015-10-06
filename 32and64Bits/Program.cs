using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36and64Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---");
            Console.WriteLine("Test 32 or 64 bit");
            Console.WriteLine("---");
            //Your code can query Environment’s Is64BitOperatingSystem property to determine
            // if it is running on a 64-bit version of Windows
            Console.WriteLine("Environment.Is64BitOperatingSystem \t {0}", Environment.Is64BitOperatingSystem);
            // Your code can also query Environment’s Is64BitProcess property to determine
            // if it is running in a 64-bit address space.
            Console.WriteLine("Environment.Is64BitProcess \t\t {0}", Environment.Is64BitProcess);
            // SizeOf IntPtr
            // 4 32-bit platform
            // 8 64-bit platform
            Console.WriteLine("SizeOf IntPtr is \t\t\t {0}", IntPtr.Size);
            Console.ReadKey();
        }
    }
}
