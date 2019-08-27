using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask2.Outputs
{
    public class ExternalDisplay : IDisplay
    {
        public void Display()
        {
            Console.WriteLine($"{nameof(ExternalDisplay)} Display called");
        }
    }
}
