namespace Patterns.RocketHeaders
{
    internal class OtherRocketHeader : IRocketHeader
    {
        public int Spacemen { get; private set; }
        public int MassShell { get; private set; }

        public OtherRocketHeader()
        {
            Spacemen = 0;
            MassShell = 100;
        }
            
        public int GetWieght()
        {
            return (Spacemen * 80) + MassShell;
        }
    }
}
