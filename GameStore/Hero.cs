using System;
using System.Collections.Generic;
using System.Threading;

namespace RPGGame
{
    public class Hero : LivingBeing
    {
        private string Race;
        private string Specialization;

        private List<string> RaceList;
        private List<string> SpecializationList;

        public Hero()
        {
            Console.WriteLine("Type a name for your hero:");
            Name = Console.ReadLine();

            RaceList = new List<string>() { "Human", "Dwarf", "Elf" };
            Console.WriteLine("\nChoose a race for your hero.\n" +
                "1. Human\n" +
                "2. Dwarf\n" +
                "3. Elf");

            Race = RaceList[Convert.ToInt32(Console.ReadLine()) - 1];

            SpecializationList = new List<string>() { "Fighter", "Cleric", "Wizard", "Rogue" };
            Console.WriteLine("\nChoose a specialization for your hero.\n" +
                "1. Fighter\n" +
                "2. Cleric\n" +
                "3. Wizard\n" +
                "4. Rogue");

            Specialization = SpecializationList[Convert.ToInt32(Console.ReadLine()) - 1];

            if (Race == "Human")
            {
                Level = 1;
                Health = 100;
                Attack = 100;
                Defense = 100;
            }
            else if (Race == "Dwarf")
            {
                Level = 1;
                Health = 130;
                Attack = 80;
                Defense = 90;
            }
            else if (Race == "Elf")
            {
                Level = 1;
                Health = 80;
                Attack = 110;
                Defense = 110;
            }

            if (Specialization == "Fighter")
            {
                Technique = "Swordslash";
            }
            else if (Specialization == "Cleric")
            {
                Technique = "Lightbeam";
            }
            else if (Specialization == "Wizard")
            {
                Technique = "Fireball";
            }
            else if (Specialization == "Rogue")
            {
                Technique = "Backstab";
            }

            Console.Clear();
            Console.WriteLine("{0}, the {1} {2}, has arrived to the land of Latam and is ready for the adventure!", Name, Race, Specialization);
            Thread.Sleep(1000);
            Console.WriteLine("\nHero Stats\n" +
                "Health: {0}\n" +
                "Attack: {1}\n" +
                "Defense: {2}\n", Health, Attack, Defense);
            Thread.Sleep(1000);
        }
    }
}
