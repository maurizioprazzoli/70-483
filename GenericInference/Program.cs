using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInference
{
    public interface Interface0
    { }

    public class Class0 : Interface0
    { }

    public interface Interface1
    { }

    public class Class1 : Interface1
    { }

    public class Class3
    {
        public void test1<T>(T arg) where T : Interface0
        { }

        public void test1(Interface1 arg)
        { }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Interface0 c0 = new Class0();
            Interface1 c1 = new Class1();

            var c3 = new Class3();

            c3.test1(c0);
            c3.test1(c1);

        }
    }
}