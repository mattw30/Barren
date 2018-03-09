using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Map map1 = new Map();
            Combat bosses = new Combat();
            Treasure T = new Treasure();
            bool death = false;
            Console.WriteLine("You have begun your venture through the Barrens Chat. Good Luck you will need it.");
            Console.WriteLine("Please input North, East, South or West");
            map1.newcompx(player1);
            map1.newcompy(player1);
            while (death == false)
            {
                string move = Console.ReadLine();
                player1.movePosition(move);
                double distance=map1.dist(map1.xcomp, map1.ycomp, player1);
                T.tres(player1);
                if (map1.dist(map1.xcomp, map1.ycomp, player1) == 0)
                {
                    player1.displayEncounterStory();
                    bosses.boss(player1);
                    death = bosses.combat(player1);
                    map1.newcompx(player1);
                    map1.newcompy(player1);
                    Console.WriteLine("Your attack is now: " + player1.attack);
                }
                else
                {
                    Console.WriteLine("You are " + distance + "m");
                }
            }
        }
    }
    class Treasure

    {

        public void tres(Player player)

        {
            Random rnd2 = new Random();
            int Random = rnd2.Next(1, 10);
            if (Random == 5) { 
            Random rnd = new Random();

            int random = rnd.Next(1, 11);

                switch (random)

                {

                    case 1:

                        Console.WriteLine("You found the sword of Imananti! Surely this blade will aid you in battle!");

                        player.attack += 5;

                        Console.WriteLine("+5 attack!");

                        break;

                    case 2:

                        Console.WriteLine("You find a troll's foot in a tree stump. This won't be helpful");

                        Console.WriteLine("+0 attack! +0 Health!");

                        break;

                    case 3:

                        Console.WriteLine("Wow! A plank of wood! This can be used agressively or defensively.");

                        player.attack += 1;

                        player.maxhealth += 2;

                        Console.WriteLine("+1 attack! +2 Health!");

                        break;

                    case 4:

                        Console.WriteLine("You step on a very sharp pebble. Better keep this!");

                        player.attack += 2;

                        Console.WriteLine("+2 attack!");
    
                    break;

                    case 5:

                        Console.WriteLine("Some witch dude cast a spell on you. You feel really powerful! ...Where did the witch go?");

                        player.attack += 3;

                        Console.WriteLine("+3attack!");

                        break;

                    case 6:

                        Console.WriteLine("Could that be the almighty chest plate of Ragnorak? No it isn't but it might provide some defence!");

                        player.maxhealth += 3;

                        Console.WriteLine("+3Health!");

                        break;

                    case 7:

                        Console.WriteLine("You find a sword in the stone! You can't pull the sword out though, so use it as a mace!");

                        player.attack += 1;

                        Console.WriteLine("+1 attack!");

                        break;

                    case 8:

                        Console.WriteLine("The great dragon of the south has blessed you with dragonic powers!");

                        player.attack += 50;

                        Console.WriteLine("+50 attack!");

                        break;

                    case 9:

                        Console.WriteLine("Bash Candicoot crawls from under a log and gives you a sheild! How kind.");

                        player.maxhealth += 6;

                        Console.WriteLine("+6 attack!");

                        break;

                    case 10:

                        Console.WriteLine("The amulet of destiny grants you power!");

                        player.maxhealth += 10;

                        Console.WriteLine("+10 Health!");

                        break;
                }

            }

        }

    }

    class Player
    {
        //Position
        public int x = 0, y = 0, health = 10, attack = 3, maxhealth=10;

        public int getXPosition()
        {
            return x;
        }

        public int getYPosition()
        {
            return y;
        }

        public void setPosition(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        public void movePosition(string movement)
        {
            if (movement.Equals("North") || movement.Equals("N")) y = y + 1;
            else if (movement.Equals("South") || movement.Equals("S")) y = y - 1;
            else if (movement.Equals("East") || movement.Equals("E")) x = x + 1;
            else if (movement.Equals("West") || movement.Equals("W")) x = x - 1;
            else Console.WriteLine("Invalid movement requested");
        }
        public void displayEncounterStory()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 11);
            switch (random)
            {
                case 1:
                    Console.WriteLine("The mighty goblin has appeared. He the king of Zordon and is unhappy with your presence. The battle begins…");
                    break;
                case 2:
                    Console.WriteLine("A group of trolls have combined into one robo - troll.It is time to prove your strength and defeat these pesky beasts.");
                    break;
                case 3:
                    Console.WriteLine("The mighty Grogo just ambushed you, he used his big foot to stomp and barely missed you. It’s now your chance to show him who’s the real boss.");
                    break;
                case 4:
                    Console.WriteLine("The elves are unhappy with your presence and demand a fight to the death. Earn their respect and defeat one elf foe.");
                    break;
                case 5:
                    Console.WriteLine("Many generations ago, you angered the sandwich lady and did not give her a payment. You have finally crossed paths and she is now fed up and wants you dead. Defeat her to move forward.");
                    break;
                case 6:
                    Console.WriteLine("The 7th leader of Azeroth, conqueror of the owl under the moon has sent his band of goons to infiltrate your treasure hunt. Eliminate the pests.");
                    break;
                case 7:
                    Console.WriteLine("The princess of Adlez’s body guards are threatened by your presence. The princess has escaped but the body guards have challenged you and will not allow you to continue your journey.");
                    break;
                case 8:
                    Console.WriteLine("Leeroy Jenkins has charged you down. You are compelled by his roar and cannot carry on with your journey until he is down.");
                    break;
                case 9:
                    Console.WriteLine("Bash Candicoot crawls from under a log and attempts to scratch you. You successfully fend of his attack. It’s time to show this monster who is boss.");
                    break;
                case 10:
                    Console.WriteLine("A swarm of insects has formed into an insect man. The insect man wants nothing but trouble and is not going to leave you alone until he is taken down.");
                    break;
            }
        }
    }

        class Map
        {

            private static readonly Random rnd = new Random();
            int near = rnd.Next(1, 11); // creates a number between 1 and 12
            int far = rnd.Next(1, 11);
            public int ycomp, xcomp;
            public static int xcord, ycord;
            public int newcompx(Player player)
            {
                xcomp = player.getXPosition() + rnd.Next(-5, 5);
                return xcomp;
            }
            public int newcompy(Player player)
            {
                ycomp = player.getYPosition() + rnd.Next(-5, 5);
                return ycomp;
            }
        public double dist(int xcomp, int ycomp, Player player)
        {
            double x = player.getXPosition();
            double y = player.getYPosition();
            return Math.Sqrt((x-xcomp) * (x-xcomp)) + ((y-ycomp) * (y-ycomp));
        }
        }
        class Combat
        {
        Random rnd = new Random();
            int bossH, bossA;
            public void boss(Player player)
            {
                bossH = player.health + rnd.Next(-5,3) ;
                bossA = player.attack + rnd.Next(-5, 3);
            if (bossA < 1)
            {
                bossA = 1;
            }
            }
            public void fight(Player player, Map map1)
            {
                if ((map1.ycomp == player.getXPosition()) && (map1.ycomp == player.getYPosition()))
                {
                    combat(player);
                }

            }
            public bool combat(Player player)
            {
                while (bossH > 0 & player.health > 0)
                {
                    bossH = bossH - player.attack;
                    player.health = player.health - bossA;
                }
                if (bossH <= 0 & player.health>0)
                {
                    Console.WriteLine("You defeated the enemy! You survived on:" + player.health +" health out of your total "+ player.maxhealth+"health");
                player.health = player.maxhealth;
                return false;
                    
                }
                else
                {
                    Console.WriteLine("You were killed");
                Console.WriteLine("You Achieved " + player.attack + "attack" + " and " + player.maxhealth + " health");
                Console.ReadLine();
                return true;
                }
            }
        }
}
