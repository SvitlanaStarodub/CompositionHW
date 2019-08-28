using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask3.Cooktop
{
    public class ElectricCooktop : Interfaces.ICook
    {
        public void Cook()
        {
            Console.WriteLine($"{nameof(ElectricCooktop)} ElectricCooktop via Cook method is called");
        }
    }
}
