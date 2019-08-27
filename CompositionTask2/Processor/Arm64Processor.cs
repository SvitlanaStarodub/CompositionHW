using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask2.Processor
{
    public class Arm64Processor : IProcessor
    {
        public void Process()
        {
            Console.WriteLine($"{nameof(Arm64Processor)} Process called");
        }
    }
}
