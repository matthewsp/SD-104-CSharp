using System;

namespace Turn_based_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentLevel = 1;
            Hero hero = new Hero();
            Monster monster = new Goblin(currentLevel);
            Console.WriteLine("Monster {1} (LV{0}) appears.", monster.level,monster.name);

            while (hero.isDead() == false)
            {
                hero.Attack(monster);
                Console.WriteLine("Hero attacks Monster!!");
                Console.ReadLine();

                if(monster.isDead())
                {
                    hero.currentExp += 20;
                    Console.WriteLine("The monster is dead!!\n");
                    hero.LevelUp();
                    currentLevel++;
                    Random rnd = new Random();
                    int monsternumber = rnd.Next(1, 6);
                    if (monsternumber == 1)
                        monster = new Goblin(currentLevel);
                    if (monsternumber == 2) 
                        monster = new SpearGoblin (currentLevel);
                    if (monsternumber == 3)
                        monster = new HoodedGoblin(currentLevel);
                    if (monsternumber == 4)
                        monster = new Skeleton(currentLevel);
                    if (monsternumber == 5)
                        monster = new Zombie(currentLevel);
                    if (monsternumber == 6)
                        monster = new ZombieArcher(currentLevel);
                    Console.WriteLine("Monster {1} (LV{0}) appears.", monster.level,monster.name);
                }
                else
                {
                    monster.Attack(hero);
                    Console.WriteLine("Monster attacks Hero!!");
                    Console.ReadLine();
                }

                if (hero.isDead() == false)
                {
                    Console.WriteLine("Hero health: " + hero.health + " HP");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("The Hero is Dead");
            Console.WriteLine("Sad music plays in background");
            Console.ReadLine();
        }
    }
}
