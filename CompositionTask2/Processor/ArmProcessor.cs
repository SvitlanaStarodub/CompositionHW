using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask2.Processor
{
    public class ArmProcessor : IProcessor
    {
        public void Process()
        {
            Console.WriteLine($"{nameof(ArmProcessor.Process)} Process called");
        }
    }
}
