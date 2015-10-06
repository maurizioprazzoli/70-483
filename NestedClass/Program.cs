using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    class Program
    {
        class Outher
        {
            private string outherPrivateType;

            public Outher()
            {
                outherPrivateType = "outherType";
            }

            public void OutherClassMethod()
            {
                Inner inner = new Inner();
                inner.InnerClassMethod(this);
                Console.WriteLine("Private method in Inner: {0}", 1);
            }

            internal class Inner
            {
                private string innerPrivateType;
                public Inner()
                {
                    innerPrivateType = "innerType";    
                }

                public void InnerClassMethod(Outher outher)
                {
                    Console.WriteLine("Private method in OutherClass: {0}",outher.outherPrivateType);
                    Console.WriteLine("Private method in InnerClass: {0}", this.innerPrivateType);
                }

            }
        }
        
        static void Main(string[] args)
        {
            Outher outClass = new Outher();
            outClass.OutherClassMethod();
        }
    }
}
