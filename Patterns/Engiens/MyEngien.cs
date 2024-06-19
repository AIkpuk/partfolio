using System;

namespace Patterns.Engiens
{
    internal class MyEngien:IEngien
    {      

        public int Weight { get; }
        public int Power { get; }
        public string Quality { get; }

        public void Start()
        {
            Console.WriteLine("Двигатель запустился");
        }
        public void Stop()
        {
            Console.WriteLine("Двигатель устал");
        }
        public MyEngien()
        {
            Weight = 700;
            Power = 300;
            Quality = "Good";
        }
    }  
}    
