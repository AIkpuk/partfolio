using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal interface IRocketHeader
    {
        int Spacemen { get; }
        int MassShell { get; }
        int GetWieght();
    }
}
