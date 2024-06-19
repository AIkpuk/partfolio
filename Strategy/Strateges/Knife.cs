using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strateges
{
    
    class Knife: IStrategy
    {
        void IStrategy.UseWeapon() 
        {
            Console.WriteLine(" тебя не навижу");
        }
    }
}
