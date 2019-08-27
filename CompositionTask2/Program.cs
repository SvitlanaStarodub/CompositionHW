using CompositionTask2.Outputs;
using CompositionTask2.Processor;
using System;

namespace CompositionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer(
                new Mouse(),
                new BuiltInDisplay(),
                new Arm64Processor());

            computer.Work();
        }
    }
}
