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
            int position = 0;
            int DiceRoll;
            int count = 0;
            Console.WriteLine("First player is starting with position " + FirstPosition);
            while(position < 100)
            {
                count++;
                Random random = new Random();
                DiceRoll = random.Next(1, 7);
                Console.WriteLine("The number player got through dice is " + DiceRoll);
                Random random2 = new Random();
                int Play = random2.Next(1, 4);
                if (Play==1)
                {
                    Console.WriteLine("Player got no play");
                    DiceRoll=0;
                    position =position + DiceRoll;
                }
                else if (Play==2)
                {
                    Console.WriteLine("Player got ladder");
                    position=(position+DiceRoll);

                }
                else
                {
                    Console.WriteLine("Player got snake");
                    position=(position-DiceRoll);
                    if (position<0)
                    {
                        position=FirstPosition;
                    }                    
                }
                if (position>100)
                {
                    position=position-DiceRoll;
                }
                Console.WriteLine("The player position is: " + position);
            }
            Console.WriteLine("No of times dice rolled is:" +count);    
            Console.ReadLine();
        }
    }
}
    