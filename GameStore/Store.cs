using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
