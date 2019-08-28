using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask3.Oven
{
    public class ElectricOven : Interfaces.IBake
    {
        public void Bake()
        {
            Console.WriteLine($"{nameof(ElectricOven)} via Bake method is called");
        }
    }
}
