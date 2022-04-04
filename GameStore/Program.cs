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

                /**
                 * enemyCount points out what is the next boss to fight with. This variable is used inside the Enemy class.
                 */
                var enemyCount = 0;

                if (inputInt == 1)
                {
                    var hero = new Hero();
                }
                else if (inputInt == 2)
                    throw new Exception();

                while (inputInt >= 1 && inputInt < 4)
                {
                    Console.WriteLine("Where would you like to go?\n" +
                        "1. Enemy Boss Fight\n" +
                        "2. Train at the barracks \n" +
                        "3. Go to the market \n" +
                        "4. Exit game");

                    inputInt = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (inputInt == 1)
                    {
                        var enemy = new Enemy(enemyCount);
                        // var battle = new Battle();
                        // If vence al boss then enemyCount++, lo que significa que sigue pelear contra el siguiente boss.
                    }
                    else if (inputInt == 2)
                    {
                        // var training = new Training();
                    }
                    else if (inputInt == 3)
                    {
                        // var market = new Market();
                    }
                }

                Console.WriteLine("Adventure is over. Thanks for playing!");

            }
            catch (Exception)
            {
                Console.WriteLine("Game will be closed. Thanks for playing!");
            }
        }
    }
}
