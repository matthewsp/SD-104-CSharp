using System;
using System.Collections.Generic;
using System.Text;

namespace Turn_based_RPG
{
    class HoodedGoblin: SpearGoblin
    {
        public HoodedGoblin()
        {
        }
        public HoodedGoblin(int level)
        {
            name = "Hooded Goblin";
            range = 2;
            if (level == 1)
                attackPower = 1;
            else
                attackPower = level * 2;
            health = 2 * level;
            this.level = level;
        }
        public override void Attack(Hero hero)
        {
            hero.health -= attackPower + range;
        }
    }
}
