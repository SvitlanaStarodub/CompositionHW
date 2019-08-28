using CompositionTask3.Interfaces;
using System;

namespace CompositionTask3.Stove
{
    public class GasStove : IStove
    {
        public void Cook()
        {
            Console.WriteLine($"{nameof(GasStove)} via Cook method is called");
        }
        public void Bake()
        {
            Console.WriteLine($"{nameof(GasStove)} via Bake method is called");
        }
    }  
}
