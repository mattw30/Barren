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

        }
    }

    class Player
    {
        //Player Stats
        private int health, attack;

        //Position
        private int x, y;


        public Player()
        {
            health = 10;
            attack = 1;
            x = 0;
            y = 0;
        }

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
            if      (movement.Equals("North") || movement.Equals("N")) y = y + 1;
            else if (movement.Equals("South") || movement.Equals("S")) y = y - 1;
            else if  (movement.Equals("East") || movement.Equals("E")) x = x + 1;
            else if  (movement.Equals("West") || movement.Equals("W")) x = x - 1;
            else Console.WriteLine("Invalid movement requested");
        }

    }
    class map
    {

        private static readonly Random rnd = new Random();
        int near = rnd.Next(1, 11); // creates a number between 1 and 12
        int far = rnd.Next(1, 11);
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
        public void findMonster()
        {
            if (xcomp -x==0 && ycomp-y == 0)
            {
                Console.WriteLine("Monster encounter!");
                Fight();
            }
        }
    }
}
