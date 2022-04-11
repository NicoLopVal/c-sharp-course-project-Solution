using TheGame.Battle;

namespace TheGame
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //dibuja bienvenida
            var welcome = new Welcome();
            var drawer = new DrawerAct();

            drawer.Draw(welcome);
            //var myHero = new Hero();              FOR TESTING PURPOSES
            //myHero.AddMoneyToPurse(99999);
            //Store.InitializeStore();
            //Store.Open(myHero);

            try
            {
                Console.WriteLine("Welcome to Magic & Steel!\nType \"Start\" to begin...");
                var inputStr = Console.ReadLine();
                Console.Clear();

                if (inputStr.ToLower() != "start")
                {
                    throw new Exception();
                }

                Console.WriteLine("Choose an option:\n" +
                    "1. Start a new adventure and create a new hero.\n" +
                    "2. Exit Game");

                var inputInt = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (inputInt == 1)
                {
                    newAdventure();
                }
                else if (inputInt == 2)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Game will be closed. Thanks for playing!");
            }
        }

        public static void newAdventure()
        {
            var enemyCount = 0;
            Hero hero = new Hero();
            hero.InitializeHero();
            bool HeroVictory = true;
            while (HeroVictory && enemyCount < 5)
            {
                Console.WriteLine("Where would you like to go?\n" +
                    "1. Enemy Boss Fight\n" +
                    "2. Train at the barracks \n" +
                    "3. Go to the market \n" +
                    "Type \"Exit\" to exit the game.");

                var input = Console.ReadLine();
                Console.Clear();
                int inputInt;
                int.TryParse(input, out inputInt);

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("You decided to end your Journey! Game will be closed.");
                    break;
                }
                else if (inputInt == 1)
                {
                    var enemy = new Enemy(enemyCount);
                    HeroVictory = BattleSituation.BattleStart(hero, enemy);
                    if (HeroVictory)
                    {
                        enemyCount++;
                        Console.Clear();
                        Console.WriteLine("¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤");
                        Console.WriteLine("------------------------------------- Congratulations! ---------------------------------------------");
                        Console.WriteLine("----------------------------- You've defeated an enemy in battle -----------------------------------");
                        Console.WriteLine("--------------------------------- Your Journey will continue ---------------------------------------");
                        Console.WriteLine("--------------------------- Enjoy the spoils, and prepare yourself! --------------------------------");
                        Console.WriteLine("¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤");

                        LootDropCalculator.DropLoot(hero);
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤");
                        Console.WriteLine("----------------------------------- You've been defeated! ------------------------------------------");
                        Console.WriteLine("------------------------------- Your hero has fallen in battle -------------------------------------");
                        Console.WriteLine("-------------------------------- Your Journey is now at an end -------------------------------------");
                        Console.WriteLine("------------------------- Maybe next time, a true champion will arise ------------------------------");
                        Console.WriteLine("¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤");
                        Console.ReadKey();
                    }

                    // If vence al boss then enemyCount++, lo que significa que sigue pelear contra el siguiente boss.
                }
                else if (inputInt == 2)
                {
                    // var training = new Training();
                }
                else if (inputInt == 3)
                {
                    //market.Open();
                }
            }
        }
    }
}
