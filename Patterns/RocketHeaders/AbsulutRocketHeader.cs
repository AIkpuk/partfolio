using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.RocketHeaders
{
    internal class AbsulutRocketHeader : AbstructHeader
    {
        int Wieght { get; }
        int Spacemen { get; }
        public AbsulutRocketHeader()
        
        {
            Wieght = 100;
            Console.WriteLine("Введите колличество людей");
            Spacemen = Convert.ToInt32(Console.ReadLine());
            GetWieght();
        }
        
    }
}
