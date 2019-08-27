using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask2.Outputs
{
    public class BuiltInDisplay : IDisplay
    {
        public void Display()
        {
            Console.WriteLine($"{nameof(BuiltInDisplay)} Display called");
        }
    }
}
