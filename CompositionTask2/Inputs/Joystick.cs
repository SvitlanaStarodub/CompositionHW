using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask2
{
    public class Joystick : IInput
    {

        public void GetInput()
        {
            Console.WriteLine($"{nameof(Joystick)} GetInput called");
        }
    }
}
