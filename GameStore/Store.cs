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

        public static void Open(object character)       //UPDATE THIS TO MATCH THE CLASS USED FOR THE CHARACTER CREATED
        {
            Console.WriteLine("Hello player: What can I offer you!?");
            ShowItemsByClass(character);
        }

        private static void ShowItemsByClass(object character)          //UPDATE THIS TO MATCH THE CLASS USED FOR THE CHARACTER CREATED
        {
            var listOfItems = items.Where(i => i.GetProperty("RaceType") == "Elf")  //UPDATE THIS TO MATCH THE CLASS USED FOR THE CHARACTER CREATED
                                    .OrderBy(i => i.GetProperty("StorePrice"));
            Console.WriteLine("Item Name     Price     Atack/Defense");
            foreach (var item in listOfItems)
            {
                //string attackOrDefense = (item is Armor)? item            //UPDATE THIS TO LOOK FOR THE ATTRIBUTE IN THE CHILD CLASS
                Console.WriteLine(item.GetProperty("ItemName") + "    " + item.GetProperty("StorePrice") + "      " + item.GetProperty(""));
            }
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
                        new Sword(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, baseDamageOrDefense);
                        break;

                    case "Bow":
                        new Bow(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, baseDamageOrDefense);
                        break;

                    case "Axe":
                        new Axe(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, baseDamageOrDefense);
                        break;

                    case "Helmet":
                        new Helmet(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, Convert.ToInt32(baseDamageOrDefense));
                        break;

                    case "Platebody":
                        new Platebody(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, Convert.ToInt32(baseDamageOrDefense));
                        break;

                    case "Boots":
                        new Boots(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, Convert.ToInt32(baseDamageOrDefense));
                        break;

                    case "Shield":
                        new Shield(storePrice, playerSellPrice, itemSubClass, specializationType, itemName, Convert.ToInt32(baseDamageOrDefense));
                        break;

                    default:
                        break;
                }

            }
        }
    }
}
