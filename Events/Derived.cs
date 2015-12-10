using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Derived : Base
    {
        public void OnCreated()
        {
            base.OnCreated();
        }
    }
}
