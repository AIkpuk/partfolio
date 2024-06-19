using Patterns.Engiens;
using Patterns.RocketHeaders;
using System;


namespace Patterns

{
    internal class Program
        {
        static void Main(string[] args)
        {

            Rocket rocket = new Rocket
            {
                Header = new AbsulutRocketHeader(),
                Engien = new MyEngien(),
            };

        int result = SpeedTest(rocket.Wieght(), rocket.Engien.Power);
        Console.WriteLine("Скорость рокеты: " + result + " км\\ч");


        if (result > 200)
        {
            rocket.Engien.Start();
        }
        else
        {
            Console.WriteLine("двигатель не запустился");
        }

        Console.ReadKey();

        
        }   
            public static int SpeedTest(int mass, int power)
            {
                return 100 * (mass / power) + 100;
            }
        }
}
