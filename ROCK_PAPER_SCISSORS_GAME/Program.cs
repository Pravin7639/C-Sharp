using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCK_PAPER_SCISSORS_GAME
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "scissors")
                {
                    Console.WriteLine("Enter ROCK,PAPER OR SCISSORS : ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }



                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;

                }
                Console.WriteLine("Player : " + player);
                Console.WriteLine("Computer : " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Its a draw!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!!");
                        }
                        else
                        {
                            Console.WriteLine("You win!!!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("you a win!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Its a draw!!");
                        }
                        else
                        {
                            Console.WriteLine("You loose!!!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You loose!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!!");
                        }
                        else
                        {
                            Console.WriteLine("Its a draw!!!");
                        }
                        break;
                }
                Console.WriteLine("would you want to play again(Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();



                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Thanks for Playing!!");


            Console.ReadLine();
        }
    }
}





