using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class EventArgument : EventArgs
    {
        public Int32 id { get; private set; }

        public EventArgument(Int32 id)
        {
            this.id = id;
        }
    }
}
