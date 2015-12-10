using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base(0);
            b.Created = create;
        }

        private static void create(object sender, EventArgument e)
        {
            throw new NotImplementedException();
        }
    }
}
