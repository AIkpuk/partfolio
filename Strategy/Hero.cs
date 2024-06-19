using Strategy.Strateges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     class Hero
    {
        private readonly string _name;
        private IStrategy? _weapon;

        public Hero(string name)
        {
            _name = name;
        }
        public void SetWeapon(IStrategy weapon)
        { 
            _weapon = weapon;
        }
        public void Attack()
        {
            Console.WriteLine(">>>");
            if (_weapon is null)
            {
                Console.WriteLine($"{_name} не могу бить, поставь оружие");
                return;
            }
            Console.WriteLine($"{_name} cтоит безумно");
            Console.Write($"{_name} ");
            _weapon.UseWeapon();
            Console.WriteLine($"{_name} встал обратно");
        }
    }
}
