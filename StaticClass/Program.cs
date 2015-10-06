using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {

        class A
        {
            public virtual void Foo() { }
        }

        class B : A
        {
            public override void Foo() { Console.WriteLine("Class B"); }
        }

        class C : A
        {
            public override void Foo() { Console.WriteLine("Class C"); }
        }

        static void Main(string[] args)
        {
            B cB = new B();
            cB.Foo(); // is a static call, no this.

            A cA = cB;
            cA.Foo(); // is polymorphic, passing cB.this.

            Console.ReadLine();
        }
    }
}
