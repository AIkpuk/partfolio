using Patterns.RocketHeaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Patterns
{
    internal class Rocket
    {
        public AbstructHeader Header { get; set; }
        public IEngien Engien { get; set; }
        public int Wieght()
        { 
            return Header.GetWieght() + Engien.Weight;
        }
    }
}
