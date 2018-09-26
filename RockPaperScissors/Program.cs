using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            var rnd = new Random();
            var playing = true;
            var winCount = 0;

            while (playing)
            {
                if (winCount == 5)
                {
                    Console.Clear();
                    Console.WriteLine("You have won 5 games, you win!");
                    Console.ReadLine();
                    break;
                }

                var ourChoice = rnd.Next(1, 4);

                Console.WriteLine("Rock, Paper, Scissors?: ");
                var playerChoice = Console.ReadLine();
                playerChoice = playerChoice.ToLower();
                var validChoices = new HashSet<string>();
                validChoices.Add("rock");
                validChoices.Add("paper");
                validChoices.Add("scissors");

                if (validChoices.Contains(playerChoice))
                {
                    if (ourChoice == 1)
                    {
                        if (playerChoice == "rock")
                        {
                            Console.WriteLine("[{0}] Computer chose Rock, Player chose Rock, it is a tie", winCount);
                            continue;
                        }

                        if (playerChoice == "paper")
                        {
                            Console.WriteLine("[{0}] Computer chose Rock, Player chose Paper, Player wins!", winCount);
                            winCount++;
                            continue;


                        }
                        if (playerChoice == "scissors")
                        {
                            Console.WriteLine("[{0}] Computer chose Rock, Player chose Sciessors, Computer wins!", winCount);
                            continue;

                        }
                    }

                    if (ourChoice == 2)
                    {
                        if (playerChoice == "rock")
                        {
                            Console.WriteLine("[{0}] Computer chose Paper, Player chose Rock, Computer wins!", winCount);
                            continue;

                        }

                        if (playerChoice == "paper")
                        {
                            Console.WriteLine("[{0}] Computer chose Paper, Player chose Paper, it's a tie", winCount);
                            continue;


                        }
                        if (playerChoice == "scissors")
                        {
                            Console.WriteLine("[{0}] Computer chose Paper, Player chose Scissors, Player wins!", winCount);
                            winCount++;
                            continue;


                        }
                    }

                    if (ourChoice == 3)
                    {
                        if (playerChoice == "rock")
                        {
                            Console.WriteLine("[{0}] Computer chose Scissors, Player chose Rock, Player wins!", winCount);
                            winCount++;
                            continue;

                        }

                        if (playerChoice == "paper")
                        {
                            Console.WriteLine("[{0}] Computer chose Scissors, Player chose Paper, Computer Wins!", winCount);
                            continue;


                        }
                        if (playerChoice == "scissors")
                        {
                            Console.WriteLine("[{0}] Computer chose Scissors, Player chose Scissors, it's a tie", winCount);
                            continue;


                        }
                    }
                }

                else
                {
                    Console.WriteLine("You did not select Rock, Paper or Scissors, try again");
                    continue;
                }



            }
        }
    }
}
