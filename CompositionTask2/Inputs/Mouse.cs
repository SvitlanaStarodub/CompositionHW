using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask2
{
    public class Mouse : IInput
    {
        public void GetInput()
        {
            Console.WriteLine($"{nameof(Mouse)} GetInput called");
        }
    }
}
