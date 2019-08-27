﻿using CompositionTask2.Outputs;
using CompositionTask2.Processor;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask2
{
    public class Computer
    {
        private IInput _input;
        private IDisplay _display;
        private IProcessor _processor;

        public Computer(
            IInput input,
            IDisplay display,
            IProcessor processor)
        {
            _input = input;
            _display = display;
            _processor = processor;
        }
        
        public void Work()
        {
            _input.GetInput();
            _display.Display();
            _processor.Process();
        }
    }
}
