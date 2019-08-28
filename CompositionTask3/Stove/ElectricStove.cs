using System;
using CompositionTask3.Interfaces;

namespace CompositionTask3.Stove
{
    public class ElectricStove : IStove
    {
        public void Cook()
        {
            Console.WriteLine($"{nameof(ElectricStove)} via Cook method is called");
        }
        public void Bake()
        {
            Console.WriteLine($"{nameof(ElectricStove)} via Bake method is called");
        }
    }
}
