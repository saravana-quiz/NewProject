using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_DS
{
    interface StackMethods
    {
        public bool IsEmpty();
        public void PushElement(object element);
        object PopElement();
        object PeekElement();
        public void DisplayStackElements();

    }
}
