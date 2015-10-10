using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAssembly
{
    public class TestClass
    {
        public int PublicMethod()
        {
            return 0;
        }

        private int PrivateMethod()
        {
            return 0;
        }

        public static int StaticMethod()
        {
            return 0;
        }
    }
}
