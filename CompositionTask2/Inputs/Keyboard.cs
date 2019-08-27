using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask2
{
    public class Keyboard : IInput
    {
        public void GetInput()
        {
            Console.WriteLine($"{nameof(Keyboard)} GetInput called");
        }
    }
}
