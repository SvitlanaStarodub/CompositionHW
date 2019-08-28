using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTask3.Cooktop
{
    public class GasCooktop : Interfaces.ICook
    {
        public void Cook()
        {
            Console.WriteLine($"{nameof(GasCooktop)} GasCooktop via Cook method is called");
        }
    }
}
