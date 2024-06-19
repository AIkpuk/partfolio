using Strategy.Strateges;
using Strategy;

Console.WriteLine("Введите имя пресонажа");

string name = Console.ReadLine();

Hero hero = new Hero(name);

Console.WriteLine("Выберите оружие");
Console.WriteLine("1. Нож");
Console.WriteLine("2. Дробовик");
Console.WriteLine(">>>");
string ChoosenWeapon = Console.ReadLine();

switch (ChoosenWeapon)
{
    case "1":
        hero.SetWeapon(new Knife());
        hero.Attack();
        break;

    case "2":
        hero.SetWeapon(new ShutGun());
        hero.Attack();
        break;

    default:
        Console.WriteLine("нет такого оружия");
        break;

}

Console.ReadLine();