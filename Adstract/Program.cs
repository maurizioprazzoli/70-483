using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adstract
{
    private abstract class testClass
    {
        public void test() { Console.WriteLine("test"); }

        public abstract void test_a();

    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
