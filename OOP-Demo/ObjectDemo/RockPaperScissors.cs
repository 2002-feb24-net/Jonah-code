using System;

namespace ObjectDemo
{
    public class RockPaperScissors
    {
        string player1, player2;
        protected int p1Wins, p1Losses, p2Wins, p2Losses, draws, rounds;

        public RockPaperScissors()
        {
            p1Wins = 0;
            p1Losses = 0;
            p2Wins = 0;
            p2Losses = 0;
            draws = 0;
            rounds = 0;
        }

        public void PlayRound(int iter, string style)
        {
            rounds += iter;
            Random random = new Random();
            int p1Move;
            int p2Move;

            for (int i = 0; i < iter; i++)
            {
                switch(style)
                {
                    case "PvAI":
                        System.Console.Write("Player 1: Rock, paper, or scissors? ");
                        player1 = "";
                        player1 = Console.ReadLine();
                        p1Move = ConvertMoveToInt(player1);
                        p2Move = random.Next(0, 3);
                        break;
                    case "PvP":
                        System.Console.Write("Player 1: Rock, paper, or scissors? ");
                        player1 = Console.ReadLine();
                        p1Move = ConvertMoveToInt(player1);
                        System.Console.Write("Player 2: Rock, paper, or scissors? ");
                        player2 = Console.ReadLine();
                        p2Move = ConvertMoveToInt(player2);
                        break;
                    default:
                        p1Move = random.Next(0, 3);
                        p2Move = random.Next(0, 3);
                        break;
                }

                if(p1Move == 0 && p2Move == 1)
                {
                    System.Console.WriteLine("Player 2 Wins!");
                    p2Wins++;//p2 wins
                }
                else if(p1Move == 0 && p2Move == 2)
                {
                    System.Console.WriteLine("Player 1 Wins!");
                    p1Wins++;//p1 wins
                }
                else if(p1Move == 1 && p2Move == 0)
                {
                    System.Console.WriteLine("Player 1 Wins!");
                    p1Wins++;//p1 wins
                }
                else if(p1Move == 1 && p2Move == 2)
                {
                    System.Console.WriteLine("Player 2 Wins!");
                    p2Wins++;//p2 wins
                }
                else if(p1Move == 2 && p2Move == 0)
                {
                    System.Console.WriteLine("Player 2 Wins!");
                    p2Wins++;//p2 wins
                }
                else if(p1Move == 2 & p2Move == 1)
                {
                    System.Console.WriteLine("Player 1 Wins!");
                    p1Wins++;//p1 wins
                }
                else
                {
                    System.Console.WriteLine("Draw!");
                    draws++;
                }
            }
        }

        protected int ConvertMoveToInt(string choice)
        {
            bool acceptableChoice = true;
            do
            {
                switch(choice)
                {
                    case "Rock": case "rock":
                        return 0;
                    case "Paper": case "paper":
                        return 1;
                    case "Scissors": case "scissors":
                        return 2;
                    default:
                        acceptableChoice = false;
                        System.Console.Write("That is not an option! Try again! ");
                        choice = Console.ReadLine();
                        continue;
                }
            } while(!acceptableChoice);
            return 0;
        }

        public void Summary()
        {
            if(rounds == 0)
            {
                System.Console.WriteLine("The games are over. :(");
            }
            else if(p1Wins > p2Wins)
            {
                System.Console.WriteLine($"Player 1 Wins! They won {p1Wins} round(s) out of {rounds}!");
                System.Console.WriteLine($"There were {draws} draws.");
            } 
            else if(p2Wins > p1Wins)
            {
                System.Console.WriteLine($"Player 2 Wins! They won {p2Wins} round(s) out of {rounds}!");
                System.Console.WriteLine($"There were {draws} draws.");
            }
            else
            {
                System.Console.WriteLine($"It was a draw!");
                if(p1Wins == 1)
                {
                    System.Console.WriteLine($"Player 1 and Player 2 each had {p1Wins} win out of {rounds} round(s)! There was {draws} draw(s)!");
                }
                else
                {
                    System.Console.WriteLine($"Player 1 and Player 2 each had {p1Wins} wins out of {rounds} rounds! There were {draws} draws!");
                }
            }
        }

        // public override string ToString()
        // {
        //     return $"product {productId}, {stock} in stock, {starRating}/5.0 star rating";
        // }
    }
}
