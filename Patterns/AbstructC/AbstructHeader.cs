namespace Patterns
{
    abstract class AbstructHeader
    {
        int Spacemen {  get; }
        int Wieght { get; }
        public int GetWieght()
        {
            return ( Spacemen * 80 ) + Wieght;
        }
    }
}
