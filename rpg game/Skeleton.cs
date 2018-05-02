using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_based_RPG
{
    class Skeleton:Monster 
    {
        public Skeleton()
        {
        }
        public Skeleton(int level)
        {
            name = "Skeleton";
            if (level == 1)
                attackPower = 1;
            else
                attackPower = level;
            health = 2 * level;
            this.level = level;
        }
        public override void Attack(Hero hero)
        {
            hero.health -= attackPower;
        }
    }

}
