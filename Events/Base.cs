using System;

namespace Events
{
    public class Base
    {
        public event EventHandler<EventArgument> Created;

        public Int32 Id { get; private set; }

        public Base(Int32 id)
        {
            this.Id = id;
        }

        public void OnCreated()
        {
            if (Created != null)
                Created(this, new EventArgument(0));
        }
    }
}
