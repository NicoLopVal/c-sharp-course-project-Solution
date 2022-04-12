using System;
using System.Collections.Generic;
using System.Threading;

namespace TheGame
{
    public class Enemy : LivingBeing
    {
        private static String[] WildCat = new string[] {@"                                    ,$$.       ,$$.      ",
                                                        @"                                   ,$'`$.     ,$'`$.     ",
                                                        @"                                   $'  `$     $'  `$     ",
                                                        @"                                  :$    $;   :$    $;    ",
                                                        @"                                  $$    $$   $$    $$    ",
                                                        @"                                  $$  _.$bqgpd$._  $$    ",
                                                        @"                                  ;$gd$$^$$$$$^$$bg$:    ",
                                                        @"                                .d$P^*'   '*'   `*^T$b.  ",
                                                        @"                               d$$$    ,*'   '*.    $$$b ",
                                                        @"                              d$$$b._    o   o    _.d$$$b",
                                                        @"                             *T$$$$$P             T$$$$$P*",
                                                        @"                               `^T$$    :'---';    $$P^' ",
                                                        @"                                  `$._   `---'   _.$'    ",
                                                        @"                                 .d$$P'**-----**'T$$b.   ",
                                                        @"                                d$$P'             `T$$b  ",
                                                        @"                               d$$P                 T$$b ",
                                                        @"                              d$P'.'               `.`T$b",
                                                        @"                              `--:                   ;--'",
                                                        @"                                 |                   |   ",
                                                        @"                                 :                   ;   ",
                                                        @"                                  \                 /    ",
                                                        @"                                  .`-.           .-'.    ",
                                                        @"                                 /   .'*--+g+--*'.   \   ",
                                                        @"                                :   /     $$$     \   ;  ",
                                                        @"                                `--'      $$$      `--'  ",
                                                        @"                                          $$$ [          ",
                                                        @"                                          $$$            ",
                                                        @"                                          :$$;           ",
                                                        @"                                          :$$;           ",
                                                        @"                                           :$$           ",
                                                        @"                                           'T$bg+.____  ",
                                                        @"                                             'T$$$$$  : ",
                                                        @"                                                 '**--' "
        };


        private static String[] Dragon = new String[]{@"       ,===:'.,            `-._              ",
                                                     @"            `:.`---.__         `-._          ",
                                                     @"              `:.     `--.         `.        ",
                                                     @"                \.        `.         `.      ",
                                                     @"        (,,(,    \.         `.   ____,-`.,   ",
                                                     @"     (,'     `/   \.   ,--.___`.'            ",
                                                     @" ,  ,'  ,--.  `,   \.;'         `            ",
                                                     @"  `{D, {    \  :    \;                       ",
                                                     @"    V,,'    /  /    //                       ",
                                                     @"    j;;    /  ,' ,-//.    ,---.      ,       ",
                                                     @"    \|'   /  ,' /  _  \  /  _  \   ,'/       ",
                                                     @"          \  `'  / \  `'  / \  `.' /         ",
                                                     @"           `.___,'   `.__,'   `.__,'         "
        };

        private static String[] Goblin = new String[]{@"             ,      ,           ",
                                                      @"            /(.-""-.)\			",
                                                      @"        |\  \/      \/  /|		",
                                                      @"        | \ / =.  .= \ / |		",
                                                      @"        \( \   o\/o   / )/		",
                                                      @"         \_, '-/  \-' ,_/		",
                                                      @"           /   \__/   \			",
                                                      @"           \ \__/\__/ /			",
                                                      @"         ___\ \|--|/ /___		",
                                                      @"       /`    \      /    `\		",
                                                      @"      /       '----'       \	"
        };

        private static String[] Golem = new String[]{@"           ___                      ",
                                                     @"         .';:;'.					   ",
                                                     @"        /_' _' /\   __			   ",
                                                     @"        ;a/ e= J/-''  '.			   ",
                                                     @"        \ ~_   (  -'  ( ;_ ,.	   ",
                                                     @"         L~''_.    -.  \ ./  )	   ",
                                                     @"         ,'-' '-._  _;  )'   (	   ",
                                                     @"       .' .'   _.'')  \  \(  |      ",
                                                     @"      /  (  .-'   __\{`', \  |	   ",
                                                     @"     / .'  /  _.-'   '  . /  |      ",
                                                     @"    / /    '-._'-,     / / \ (	   ",
                                                     @" __/ (_    ,;' .-'    / /  /_'-._   ",
                                                     @"`' - '` ~`  ccc.'   __.','     \j\L\",
                                                     @"                 .='/|\7      	   ",
                                                     @"     	           ' `			   "
        };

        private static String[] Orc = new String[]{@"         _......._               ",
                                                   @"       .-'.'.'.'.'.'.`-.		  ",
                                                   @"     .'.'.'.'.'.'.'.'.'.`.		  ",
                                                   @"    /.'.'               '.\	  ",
                                                   @"    |.'    _.--...--._     |	  ",
                                                   @"    \    `._.-.....-._.'   /	  ",
                                                   @"    |     _..- .-. -.._   |	  ",
                                                   @" .-.'    `.   ((@))  .'   '.-.	  ",
                                                   @"( ^ \      `--.   .-'     / ^ )  ",
                                                   @" \  /         .   .       \  /	  ",
                                                   @" /          .'     '.  .-    \	  ",
                                                   @"( _.\    \ (_`-._.-'_)    /._\)  ",
                                                   @" `-' \   ' .--.          / `-'	  ",
                                                   @"     |  / /|_| `-._.'\   |       ",
                                                   @"     |   |       |_| |   /-.._   ",
                                                   @" _..-\   `.--.______.'  |		  ",
                                                   @"      \       .....     |        ",
                                                   @"       `.  .'      `.  /		  ",
                                                   @"         \           .'          ",
                                                   @"          `-..___..-`			  "
        };

        private List<Items> ItemList;

        private List<string> NameList;
        
        public Enemy(int enemyCount)
        {
            NameList = new List<string>() { "WildCat", "Goblin", "Orc", "Golem", "Dragon" };
            Name = NameList[enemyCount];

            if (Name == "Goblin")
            {
                Level = 5;
                maxHealth = 110;
                currentHealth = maxHealth;
                Attack = "1d4";
                ArmorClass = 8;
                attackRollModifier = 0;
                Technique = "Stone Throw";
            }
            else if (Name == "Orc")
            {
                Level = 10;
                maxHealth = 150;
                currentHealth = maxHealth;
                Attack = "2d4";
                ArmorClass = 10;
                Technique = "Axe Sweep";
                attackRollModifier = 2;
            }
            else if (Name == "Golem")
            {
                Level = 20;
                maxHealth = 500;
                currentHealth = maxHealth;
                Attack = "3d4";
                ArmorClass = 13;
                Technique = "Totemstorm";
                attackRollModifier = 4;
            }
            else if (Name == "Dragon")
            {
                Level = 50;
                maxHealth = 1000;
                currentHealth = maxHealth;
                Attack = "5d6";
                ArmorClass = 15;
                Technique = "Firebreath";
                attackRollModifier = 6;
            }
            else if(Name == "WildCat")
            {
                Level = 3;
                maxHealth = 25;
                currentHealth = maxHealth;
                Attack = "1d1";
                ArmorClass = 8;
                attackRollModifier = 0;
                Technique = "Scratch";
            }
            
            if (Name == "WildCat")
                Drawer.Draw(WildCat);
            else if (Name == "Dragon")
                Drawer.Draw(Dragon);
            else if (Name == "Golem")
                Drawer.Draw(Golem);
            else if (Name == "Orc")
                Drawer.Draw(Orc);
            else if (Name == "Goblin")
                Drawer.Draw(Goblin);
            Console.WriteLine("{0} has appeared. Get ready to fight!", Name);
            Thread.Sleep(3000);
            Console.WriteLine("\nEnemy Stats\n" +
                "Health: {0}\n" +
                "Attack: {1}\n" +
                "Defense: {2}\n", currentHealth, Attack, ArmorClass);
            Thread.Sleep(1000);
        }
    }

}
