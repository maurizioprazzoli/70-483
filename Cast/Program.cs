using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast
{

    class A
    {
        public string Status { get; set; }

        public static implicit operator A(C b)
        {
            A a = new A();
            a.Status = "implicit conversion from C";
            return a;
        }
        
        public static explicit operator A (B b)
        {
            A a = new A();
            a.Status = "explicit conversio from B";
            return a;
        }


    }

    class B
    {

    }

    class C
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32 myInt;
            myInt = 4;
            object obj;
            obj = myInt;
            myInt = (Int32)obj;

            myInt = obj is Int32 ? (int)obj : 0;

            A a = new A();
            B b = new B();
            C c = new C();
            
            a = (A)b;
            a = c;
            

        }
    }
}
