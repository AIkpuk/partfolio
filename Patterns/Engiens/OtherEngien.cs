using System;

namespace Patterns.Engiens
{
    internal class OtherEngien : IEngien
    {   
        
        public int Weight { get; }
        public int Power { get; }
        public string Quality { get; }

        public void Start()
        {
            Console.WriteLine("Двигатель запустился с трудом");
        }
        public void Stop()
        {
            Console.WriteLine("Он не умеет останавливатся");
        }
        public OtherEngien()
        {
            Weight = 100;
            Power = 100;
            Quality = "Плохо";
        }
    }
}
