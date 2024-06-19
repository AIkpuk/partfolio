namespace Strategy.Strateges
{
    internal class ShutGun : IStrategy
    {
        void IStrategy.UseWeapon()
        {
            Console.WriteLine("Стреляет из дробовика");
        }
    }
}
