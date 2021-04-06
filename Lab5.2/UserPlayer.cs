using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class UserPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Console.Clear();
            Console.WriteLine("Please select from the following: ");
            Console.WriteLine("1: Rock");
            Console.WriteLine("2: Paper");
            Console.Write("3: Scissors: ");

            int choice = 0;
            bool fPass = true;
            while (choice < 1 || choice > 3)
            {
                if (!fPass)
                    Console.Write("\nPlease enter valid input (1-3): ");
                Int32.TryParse(Console.ReadLine(), out choice);
                fPass = false;
            }

            switch (choice)
            {
                case 1:
                    return Roshambo.Rock;
                case 2:
                    return Roshambo.Paper;
                default:
                    return Roshambo.Scissors;
            }
        }
    }
}
