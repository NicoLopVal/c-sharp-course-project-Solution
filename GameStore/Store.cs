using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheGame
{
    internal class Store
    {
        private static List<Items> items = new List<Items>();
        public Store()
        {
        }

        public static void Open(Hero character)
        {
            var characterRace = character.GetRace();                         //UPDATE THIS TO MATCH THE CLASS USED FOR THE CHARACTER CREATED

            Console.WriteLine("Hello " + characterRace + ", Why are you here?");       // Check with Juanma to see how to get the Race
            
            while (true)
            {
                Console.WriteLine("Your Gold: " + character.GetMoney());
                Console.WriteLine("1. Buy some items.");
                Console.WriteLine("2. Sell some stuff!");
                Console.WriteLine("Any other key to leave the market!");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    OpenBuyItems(character);
                    if (!AnythingElse())
                        break;

                }
                else if (answer == "2")
                {
                    OpenSellItems(character);
                    if (!AnythingElse())
                        break;
                }
                else
                    break;
                Console.Clear();
            }
            Console.WriteLine("Thanks for coming! I hope to see you again " + character.Name);
        }

        private static void OpenBuyItems(Hero character)
        {
            Console.Clear();
            Console.WriteLine("(Your Gold: {0})", character.GetMoney());
            Console.WriteLine("This is what I've got:");
            var availableItems = ShowItemsByClass(character.GetSpecialization());
            Console.WriteLine("Please type the number of the item you want to buy, or any other key to return to the main market menu:");
            var answer = Console.ReadLine();
            try
            {
                var optionSelected = Convert.ToInt32(answer);
                if (optionSelected < availableItems.Count() && optionSelected > -1)
                {
                    int counter = 0;
                    foreach (var item in availableItems)
                    {
                        if (counter == optionSelected)
                        {
                            if (CheckPurseToBuy(Convert.ToInt32(item.GetProperty("StorePrice")), character))
                            {
                                if (character.EquipItem(item))
                                {
                                    character.ReduceMoneyFromPurse(Convert.ToInt32(item.GetProperty("StorePrice")));
                                    Console.Clear();
                                    Console.WriteLine("{0} adquired and equiped!", item.GetProperty("ItemName"));
                                }
                                Console.WriteLine();
                            }
                        }
                        counter++;
                    }
                }
                else
                    Console.Clear();
            }
            catch
            {
                Console.Clear();
            }
        }
        private static void OpenSellItems(Hero character)
        {
            var myItems = character.GetArmor();
            var activeItems = new List<Items>();
            foreach(Items item in myItems.Values)
            {
                if(item != null)
                {
                    activeItems.Add(item);
                }
            }
            if(activeItems.Count == 0)
            {
                Console.WriteLine("You don't have nothing to sell right now...");
                return;
            }
            else
            {
                Console.WriteLine("Type the number of the item you want to sell or a different key to cancel:");
                var counter = 0;
                Console.WriteLine("Option   Price   Item Name");
                foreach (Items item in activeItems)
                {
                    Console.WriteLine("  " + counter + "        " + item.GetProperty("PlayerSellPrice") + "       " + item.GetProperty("ItemName"));
                    counter++;
                }
                string answer = Console.ReadLine();
                try
                {
                    if (Convert.ToInt32(answer) >= 0 && Convert.ToInt32(answer) < activeItems.Count())
                    {
                        if (character.RemoveItem(activeItems[Convert.ToInt32(answer)]))
                            character.AddMoneyToPurse(Convert.ToInt32(activeItems[Convert.ToInt32(answer)].GetProperty("PlayerSellPrice")));
                    }
                }
                catch { }
            }
        }

        private static IOrderedEnumerable<Items> ShowItemsByClass(string specialization)
        {
            var counter = 0;
            var listOfItems = items.Where(i => i.GetProperty("RaceType") == specialization || i.GetProperty("RaceType") == "All") 
                                    .OrderBy(i => Convert.ToInt32(i.GetProperty("StorePrice")));
            Console.WriteLine("Option   Price   Atack/Defense   Item Name");
            foreach (var item in listOfItems)
            {
                if(item is Weapon)
                {
                    Weapon weapon = (Weapon)item;
                    Console.WriteLine("  " + counter + "        " + item.GetProperty("StorePrice") + "       " + weapon.GetWeaponDamageRoll() + "    " + item.GetProperty("ItemName"));
                }
                else
                {
                    Armor armor = (Armor)item;
                    Console.WriteLine("  " + counter + "        " + item.GetProperty("StorePrice") + "       " + armor.GetDefense() + "    " + item.GetProperty("ItemName"));
                }
                counter++;
            }
            Console.WriteLine();
            return listOfItems;
        }

        public static void InitializeStore()
        {
            var ItemFileDirectory = @"C:\Users\BairesDev NLV\Desktop\Items.txt";
            //YOU CAN ADD HERE YOUR DIRECTORY WITH THE TEXT FILE TO D OTHE TESTINGS File shared: 
            //https://docs.google.com/spreadsheets/d/1KmO_y81h5r5Cpn8NWafyxcH_BD4gKHIM6P1zYt8pLvc/edit#gid=1877859927
            var lines = File.ReadLines(ItemFileDirectory);
            foreach (var line in lines)
            {
                var lineValues = line.Split(',');
                var storePrice = Convert.ToInt32(lineValues[0]);
                var playerSellPrice = Convert.ToInt32(lineValues[1]);
                var ItemClass = lineValues[2];
                var itemSubClass = lineValues[3];
                var specializationType = lineValues[4];
                var itemName = lineValues[5];
                var baseDamageOrDefense = lineValues[6];

                switch (itemSubClass)
                {
                    case "Sword":
                        items.Add(new Sword(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, baseDamageOrDefense));
                        break;

                    case "Bow":
                        items.Add(new Bow(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, baseDamageOrDefense));
                        break;

                    case "Staff":
                        items.Add(new Staff(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, baseDamageOrDefense));
                        break;

                    case "Vaculum":
                        items.Add(new Staff(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, baseDamageOrDefense));
                        break;

                    case "Helmet":
                        items.Add(new Helmet(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, Convert.ToInt32(baseDamageOrDefense)));
                        break;

                    case "Platebody":
                        items.Add(new Platebody(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, Convert.ToInt32(baseDamageOrDefense)));
                        break;

                    case "Boots":
                        items.Add(new Boots(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, Convert.ToInt32(baseDamageOrDefense)));
                        break;

                    case "Shield":
                        items.Add(new Shield(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, Convert.ToInt32(baseDamageOrDefense)));
                        break;

                    default:
                        break;
                }

            }
        }

        private static bool AnythingElse()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Do you need anything else?");
            Console.WriteLine("1. Yes, go to market main menu.");
            Console.WriteLine("Any other key to leave the market");
            string answer = Console.ReadLine();
            if (answer == "1")
                return true;
            else
                return false;
        }

        private static bool CheckPurseToBuy(int cost, Hero character)
        {
            if (character.GetMoney() >= cost)
                return true;
            Console.WriteLine("Sorry, you don't have enough money...");
            return false;
        }
    }
}
