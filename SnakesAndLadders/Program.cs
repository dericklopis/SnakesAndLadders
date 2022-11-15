using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstPosition=0;
            int PlayerPosition=FirstPosition;
            Console.WriteLine("First player is starting with position " + FirstPosition);
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("The number player got through dice is " + DiceRoll); 
            Console.ReadLine();
        }
    }
}
