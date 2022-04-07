using System;
using System.Collections.Generic;
using System.Threading;

namespace TheGame
{
    public class Hero : LivingBeing
    {
        private string Race;
        private string Specialization;
        private Weapon weapon;
        private int Purse;
        private Helmet? MyHelm;
        private Platebody? MyPlatebody;
        private Boots? MyBoots;
        private Shield? MyShield;
        private Weapon? MyWeapon;
        private List<string> RaceList;
        private List<string> SpecializationList;

        public Hero()
        {
        }

        public void InitializeHero()
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
                maxHealth = 100;
                currentHealth = maxHealth;
                Attack = "1d4";
                ArmorClass = 10;
            }
            else if (Race == "Dwarf")
            {
                Level = 1;
                maxHealth = 130;
                currentHealth = maxHealth;
                Attack = "1d4";
                ArmorClass = 11;
            }
            else if (Race == "Elf")
            {
                Level = 1;
                maxHealth = 80;
                currentHealth = maxHealth;
                Attack = "1d4";
                ArmorClass = 12;
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
                "Defense: {2}\n", currentHealth, Attack, ArmorClass);
            Thread.Sleep(1000);
        }

        public new string getAttackRoll()
        {
            return weapon.GetWeaponDamageRoll();
        }

        public void restoreHP()
        {
            currentHealth = maxHealth;
        }
        public int GetMoney()
        {
            return Purse;
        }

        public void AddMoneyToPurse(int addValue)
        {
            Purse += addValue;
        }

        public void ReduceMoneyFromPurse(int reduceValue)
        {
            Purse -= reduceValue;
        }

        public string GetRace()
        {
            return this.Race;
        }

        public string GetSpecialization()
        {
            return this.Specialization;
        }

        public Dictionary<string,Items> GetArmor()
        {
            var myItems = new Dictionary<string,Items>();
            myItems.Add("Helmet", MyHelm);
            myItems.Add("Platebody", MyPlatebody);
            myItems.Add("Boots", MyBoots);
            myItems.Add("Shield", MyShield);
            myItems.Add("Weapon", MyWeapon);

            return myItems;
        }

        public bool EquipItem(Items selectedItem)
        {
            if (selectedItem is Weapon)
            {
                if (this.MyWeapon == null)
                {
                    MyWeapon = (Weapon)selectedItem;
                    return true;
                }

                Console.WriteLine("Item could not be equiped because you're already using " + MyWeapon.GetProperty("ItemName"));
                return false;
            }
            else if (selectedItem is Helmet)
            {
                if (this.MyHelm == null)
                {
                    MyHelm = (Helmet)selectedItem;
                    return true;
                }

                Console.WriteLine("Item could not be equiped because you're already using " + MyHelm.GetProperty("ItemName"));
                return false;
            }
            else if (selectedItem is Platebody)
            {
                if (this.MyPlatebody == null)
                {
                    MyPlatebody = (Platebody)selectedItem;
                    return true;
                }

                Console.WriteLine("Item could not be equiped because you're already using " + MyPlatebody.GetProperty("ItemName"));
                return false;
            }
            else if (selectedItem is Boots)
            {
                if (this.MyBoots == null)
                {
                    MyBoots = (Boots)selectedItem;
                    return true;
                }

                Console.WriteLine("Item could not be equiped because you're already using " + MyBoots.GetProperty("ItemName"));
                return false;
            }
            else if (selectedItem is Shield)
            {
                if (this.MyShield == null)
                {
                    MyShield = (Shield)selectedItem;
                    return true;
                }

                Console.WriteLine("Item could not be equiped because you're already using " + MyShield.GetProperty("ItemName"));
                return false;
            }
            else
            {
                Console.WriteLine("Item could not be equiped.");
                return false;
            }
        }

        public bool RemoveItem(Items removeItem)
        {
            bool result = false;
            if(removeItem is Helmet)
            {
                try
                {
                    this.MyHelm = null;
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            else if (removeItem is Platebody)
            {
                try
                {
                    this.MyPlatebody = null;
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            else if (removeItem is Boots)
            {
                try
                {
                    this.MyBoots = null;
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            else if (removeItem is Shield)
            {
                try
                {
                    this.MyShield = null;
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            else if (removeItem is Weapon)
            {
                try
                {
                    this.MyWeapon = null;
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }

            if (result)
                Console.WriteLine("{0} was removed and sold!", removeItem.GetProperty("ItemName"));
            else
                Console.WriteLine("Didn't remove anything");

            return result;
        }
    }
}
