using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("hi");
            Console.ReadLine();
                Player player1 = new Player();
                Map map1 = new Map();
                Combat bosses = new Combat();
                bool death = False;
                Console.WriteLine("Description");
                Console.WriteLine("Please input North, East, South or West");
                while (death == False)
                {
                    string move = Console.ReadLine();
                    player1.movePosition(move);
                    map1.dist();
                    if (map1.dist() == 0)
                    {
                        bosses.combat();
                    }
                    //Stats etc
                    map.newxcomp();
                    map.newycomp();
                }
            }
    }

    class Player
    {
        //Position
        public int x = 0, y = 0, health = 10, attack = 1;

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

        class Map
        {

            private static readonly Random rnd = new Random();
            int near = rnd.Next(1, 11); // creates a number between 1 and 12
            int far = rnd.Next(1, 11);
            int ycomp, xcomp;
            public static int xcord, ycord;
            public int newcompx(int x)
            {
                xcomp = x + rnd.Next(-5, 5);
                return xcomp;
            }
            public int newcompy(int y)
            {
                ycomp = y + rnd.Next(-5, 5);
                return ycomp;
            }
        }
        class Combat
        {
            int bossH, bossA;
            public void boss()
            {
                bossH = 20;
                bossA = 10;
            }
            public void fight()
            {
                if ((Map.ycomp == player.getXPosition()) && (Map.ycomp == player.getYPosition()))
                {
                    combat();
                }

            }
            public void combat()
            {
                while (bossH > 0 & health > 0)
                {
                    bossH = bossH - attack;
                    health = health - bossA;
                }
                if (bossH < 0)
                {
                    Console.WriteLine("You defeated the enemy!");
                }
                else
                {
                    Console.WriteLine("You are dead");
                }
            }
        }
    }
}

