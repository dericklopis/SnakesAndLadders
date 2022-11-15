using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FirstPosition =0;
            int position1 = 0;
            int position2 = 0;
            int DiceRoll1, DiceRoll2;
            int count = 0;
            Console.WriteLine("Player 1 is starting with position " + FirstPosition);
            Console.WriteLine("Player 2 is starting with position " + FirstPosition);
            while (position1 < 100 || position2 < 100)
            {
                count++;
                Random random1 = new Random();
                DiceRoll1 = random1.Next(1, 7);
                Random random2 = new Random();
                DiceRoll2 = random2.Next(1, 7);
                Console.WriteLine("The number player 1 got through dice is " + DiceRoll1);
                Console.WriteLine("The number player 2 got through dice is " + DiceRoll2);
                Random random3 = new Random();
                int Play1 = random3.Next(1, 4);
                Random random4 = new Random();
                int Play2 = random4.Next(1, 4);
                if (Play1==1)
                {
                    Console.WriteLine("Player 1 got no play");
                    DiceRoll1=0;
                    position1 =position1 + DiceRoll1;
                }
                else if (Play1==2)
                {
                    Console.WriteLine("Player 1 got ladder");
                    position1=(position1+DiceRoll1);

                }
                else
                {
                    Console.WriteLine("Player 1 got snake");
                    position1=(position1-DiceRoll1);
                    if (position1<0)
                    {
                        position1=FirstPosition;
                    }                    
                }
                if (position1>100)
                {
                    position1=position1-DiceRoll1;
                }
                Console.WriteLine("The player 1 position is: " + position1);
                


                if (Play2==1)
                {
                    Console.WriteLine("Player 2 got no play");
                    DiceRoll2=0;
                    position2 =position2 + DiceRoll2;
                }
                else if (Play2==2)
                {
                    Console.WriteLine("Player 2 got ladder");
                    position2=(position2+DiceRoll2);

                }
                else
                {
                    Console.WriteLine("Player 2 got snake");
                    position2=(position2-DiceRoll2);
                    if (position2<0)
                    {
                        position2=FirstPosition;
                    }
                }
                if (position2>100)
                {
                    position2=position2-DiceRoll2;
                }
                Console.WriteLine("The player 2 position is: " + position2);
            }
            Console.WriteLine("No of times players rolled dice is:" +count);
            if (position1==100)
                Console.WriteLine("Player1 Won the Match");  
            else
            Console.WriteLine("Player2 Won the Match");
            Console.ReadLine();
        }
    }
}
    