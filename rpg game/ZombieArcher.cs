using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_based_RPG
{
    class ZombieArcher:Monster
    {
        public ZombieArcher()
        {
        }
        public ZombieArcher(int level)
        {
            name = "Zombie Archer";
            range = 1;
            if (level == 1)
                attackPower = 1;
            else
                attackPower = level * 2;
            health = 3 * level;
            this.level = level;
        }
        public override void Attack(Hero hero)
        {
            hero.health -= attackPower;
        }
    }
}
