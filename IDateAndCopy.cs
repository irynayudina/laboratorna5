using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace laboratorna5
{
    interface IDateAndCopy
    {
        public abstract object DeepCopy();
        public abstract DateTime Date { get; set; }
    }
}
