using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {

        class testProperty
        {
            //public Int32 get_test()
            //{
            //    Console.Write("Get_test!");
            //    return 0;
            //}

            private static String Name {
                get { return null; }
                set { }
            }
            static void MethodWithOutParam(out String n) { n = null; }

            public Int32 aip { get; set; }

            

            public virtual Int32 test
            {
                get
                {
                    //MethodWithOutParam(out Name);
                    var i = 10;
                    Console.Write(i.GetType());
                    return 0;
                }
                set
                {
                    var i = 33;
                    Console.Write(i.GetType());
                    Console.Write("Set!");
                }
            }
        }
        static void Main(string[] args)
        {
            (new testProperty()).test = 2;
            //(new testProperty()).get_test();
            Console.ReadKey();
        }
    }
}
