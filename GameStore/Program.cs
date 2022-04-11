using TheGame.Battle;

namespace TheGame
{
    public static class Program
    {
        private static String[] Welcome = new String[]{@"╔╦╦╦═╦╗╔═╦═╦══╦═╗      ",
                                                       @"║║║║╩╣╚╣═╣║║║║║╩╣        ",
                                                       @"╚══╩═╩═╩═╩═╩╩╩╩═╝        ",
                                                       @"          {}             ",
                                                       @"         .--.            ",
                                                       @"        /.--.\           ",
                                                       @"        |====|           ",
                                                       @"        |`::`|           ",
                                                       @"    .-;`\..../`;_.-^-._  ",
                                                       @"   /  |...::..|`   :   `|",
                                                       @"  |   /'''::''|   .:.   |",
                                                       @"  ;--'\   ::  |..:::::..|",
                                                       @"  <__> >._::_.| ':::::' |",
                                                       @"  |  |/   ^^  |   ':'   |",
                                                       @"  \::/|       \    :    /",
                                                       @"  |||\|        \   :   / ",
                                                       @"  ''' |___/\___|`-.:.-`  ",
                                                       @"       \_ || _/    `     ",
                                                       @"       <_ >< _>          ",
                                                       @"       |  ||  |          ",
                                                       @"       |  ||  |          ",
                                                       @"      _\.:||:./_         ",
                                                       @"     /____/\____\        ",
        };

        static void Main(string[] args)
        {
            Drawer.Draw(Welcome);
            Store.InitializeStore();
            

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
            var enemyCount = 1;
            Hero hero = new Hero();
            hero.InitializeHero();
            //hero.AddMoneyToPurse(99999);          //FOR TESTING PURPOSES
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
                    if (HeroVictory && enemyCount <4)
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
                    else if(HeroVictory && enemyCount == 4)
                    {
                        Console.WriteLine(@"                 __     ______  _    _  __          ______  _   _ _ ");
                        Console.WriteLine(@"                 \ \   / / __ \| |  | | \ \        / / __ \| \ | | |");
                        Console.WriteLine(@"                  \ \_/ / |  | | |  | |  \ \  /\  / / |  | |  \| | |");
                        Console.WriteLine(@"                   \   /| |  | | |  | |   \ \/  \/ /| |  | | . ` | |");
                        Console.WriteLine(@"                    | | | |__| | |__| |    \  /\  / | |__| | |\  |_|");
                        Console.WriteLine(@"                    |_|  \____/ \____/      \/  \/   \____/|_| \_(_)");
                        Console.WriteLine(@"  _______ _                 _           __             _____  _             _             _ ");
                        Console.WriteLine(@" |__   __| |               | |         / _|           |  __ \| |           (_)           | |");
                        Console.WriteLine(@"    | |  | |__   __ _ _ __ | | _____  | |_ ___  _ __  | |__) | | __ _ _   _ _ _ __   __ _| |");
                        Console.WriteLine(@"    | |  | '_ \ / _` | '_ \| |/ / __| |  _/ _ \| '__| |  ___/| |/ _` | | | | | '_ \ / _` | |");
                        Console.WriteLine(@"    | |  | | | | (_| | | | |   <\__ \ | || (_) | |    | |    | | (_| | |_| | | | | | (_| |_|");
                        Console.WriteLine(@"    |_|  |_| |_|\__,_|_| |_|_|\_\___/ |_| \___/|_|    |_|    |_|\__,_|\__, |_|_| |_|\__, (_)");
                        Console.WriteLine(@"                                                                       __/ |         __/ |  ");
                        Console.WriteLine(@"                                                                      |___/         |___/   ");
                        break;
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
                    Console.WriteLine();
                }
                else if (inputInt == 2)
                {
                    var enemy = new Enemy(0);
                    HeroVictory = BattleSituation.BattleStart(hero, enemy);
                    if (HeroVictory)
                    {
                        Console.Clear();
                        Console.WriteLine("¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤");
                        Console.WriteLine("------------------------------------- Congratulations! ---------------------------------------------");
                        Console.WriteLine("---------------------------- You've defeated an enemy in training ----------------------------------");
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
                        Console.WriteLine("------------------------- Keep training so this won't happen again! --------------------------------");
                        Console.WriteLine("¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤º°`°º¤ø,¸¸,ø¤º°`°º¤ø,¸,ø¤°º¤ø,¸¸,ø¤");
                    }
                    Console.WriteLine();
                }
                else if (inputInt == 3)
                {
                    Store.Open(hero);
                }
                else if(input == "mymoney")
                {
                    Console.Clear();
                    Drawer.Draw(Store.GetMoneyPassword());
                    Console.WriteLine("I FOUND A PILE OF GOLD!!!");
                    hero.AddMoneyToPurse(99999);
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
