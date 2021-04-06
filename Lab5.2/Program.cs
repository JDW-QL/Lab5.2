using System;

namespace Lab5._2
{
    class Program
    {
        static void Result(string endResult, Player u, Player o)
        {
            if (endResult == "Win")
            {
                Console.WriteLine($"{u.Name} threw {u.Rosh} while {o.Name} threw {o.Rosh}!");
                Console.WriteLine("You win!");
            }
            else if (endResult == "Lose")
            {
                Console.WriteLine($"{u.Name} threw {u.Rosh} while {o.Name} threw {o.Rosh}!");
                Console.WriteLine("You lose!");
            }
            else // (endResult == "Tie")
            {
                Console.WriteLine($"Both {u.Name} and {o.Name} threw {u.Rosh}!");
                Console.WriteLine("You tied!");
            }
           

        }
        public static bool Repeat()
        {
            string yn = "";
            bool fPass = true;

            while (yn != "y" && yn != "n")
            {
                if (fPass == false)
                    Console.WriteLine("Please enter valid input.");
                Console.Write("\nWould you like to play again? (y/n): ");
                yn = Console.ReadLine().ToLower();
                fPass = false;
            }

            if (yn == "y")
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            UserPlayer user = new UserPlayer();


            Console.WriteLine("\n\n                                         Welcome to Rock Paper Scissors!\n\n");
            Console.Write("                                         Enter your name: ");
            user.Name = Console.ReadLine();

            Console.WriteLine("\n\n\nWho would you like to play against?");
            Console.WriteLine("(1)RockThrower");
            Console.WriteLine("(2)CannotMakeUpHisOrHerMind? ");

            int choice = 0;
            bool fPass = true;
            while (choice < 1 || choice > 2)
            {
                if (fPass == false)
                    Console.Write("\nPlease enter valid input 1 or 2: ");
                Int32.TryParse(Console.ReadLine(), out choice);
                fPass = false;
            }
            Console.Clear();
            if (choice == 1)
            {
                do
                {
                    RockThrower op = new RockThrower();
                    op.Rosh = op.GenerateRoshambo();
                    op.Name = "RockThrower";
                    user.Rosh = user.GenerateRoshambo();
                    Console.Clear();
                    if (user.Rosh == Roshambo.Rock)
                        Result("Tie", user, op);
                    else if (user.Rosh == Roshambo.Paper)
                        Result("Win", user, op);
                    else
                        Result("Lose", user, op);
                } while (Repeat());
            }
            else
            {

                do
                {
                    CannotMakeUpHisOrHerMind op = new CannotMakeUpHisOrHerMind();
                    op.Name = "CannotMakeUpHisOrHerMind";
                    op.Rosh = op.GenerateRoshambo();
                    user.Rosh = user.GenerateRoshambo();
                    Console.Clear();
                    if (user.Rosh == op.Rosh)
                        Result("Tie", user, op);
                    else if (user.Rosh == Roshambo.Rock && op.Rosh == Roshambo.Scissors)
                        Result("Win", user, op);
                    else if (user.Rosh == Roshambo.Rock && op.Rosh == Roshambo.Paper)
                        Result("Lose", user, op);
                    else if (user.Rosh == Roshambo.Paper && op.Rosh == Roshambo.Rock)
                        Result("Win", user, op);
                    else if (user.Rosh == Roshambo.Paper && op.Rosh == Roshambo.Scissors)
                        Result("Lose", user, op);
                    else if (user.Rosh == Roshambo.Scissors && op.Rosh == Roshambo.Paper)
                        Result("Win", user, op);
                    else // (user.Rosh == Roshambo.Scissors && op.Rosh == Roshambo.Rock)
                        Result("Lose", user, op);
                } while (Repeat());
            }
            Console.Clear();
            Console.WriteLine("Thanks for playing");
        }
    }
}
