using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Program te = new Program();
            ParameterizedThreadStart  p = new ParameterizedThreadStart(te.test);
            Thread t = new Thread(p);
            Console.WriteLine("t.IsBackground: {0}", t.IsBackground);
            t.IsBackground = true;
            Console.WriteLine("t.IsBackground: {0}", t.IsBackground);
            t.Start("ciao!");
        }


        public void test(object s)
        {
            Console.WriteLine("s: {0}", s);
            Console.ReadLine();
        }
    }
}
