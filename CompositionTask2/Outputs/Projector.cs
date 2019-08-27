using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask2.Outputs
{
    public class Projector : IDisplay
    {
        public void Display()
        {
            Console.WriteLine($"{nameof(Projector)} Display called");
        }
    }
}
