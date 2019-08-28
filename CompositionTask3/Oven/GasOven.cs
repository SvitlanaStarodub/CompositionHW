using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask3.Oven
{
    public class GasOven : Interfaces.IBake
    {
        public void Bake()
        {
            Console.WriteLine($"{nameof(GasOven)} via Bake method is called");
        }
    }
}
