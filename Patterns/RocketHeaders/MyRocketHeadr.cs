using System;

namespace Patterns.RocketHeaders
{
    internal class MyRocketHeader: IRocketHeader
    {
            public int Spacemen { get; private set; }
            public int MassShell { get; private set; }


            public MyRocketHeader()
            {
                Console.WriteLine("Введите колличество пассажиров ");
                Spacemen = Convert.ToInt32(Console.ReadLine());
                MassShell = 5000;
            }
            public int GetWieght()
            {
                return (Spacemen * 80) + MassShell;
            }
            public void SendMessage(string messege)
            {
                Console.WriteLine("Сообщение ");
                Console.WriteLine(messege);
                Console.WriteLine("отправлено");

            }
        
    }
}
