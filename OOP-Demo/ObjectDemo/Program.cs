using System;

namespace ObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissors game = new RockPaperScissors();
            bool quit = false;
            
            while(!quit)
            {
                System.Console.WriteLine("Would you like to play Rock-Paper-Scissors? (y/n)");
                string yesOrNo = Console.ReadLine();

                if(yesOrNo == "y")
                {
                    string gameStyle = "";
                    while(!gameStyle.Equals("PvP") || !gameStyle.Equals("PvAI") || !gameStyle.Equals("AIvAI"))
                    {
                        System.Console.Write("Do you want PvP, PvAI, or AIvAI? ");
                        gameStyle = Console.ReadLine();
                    }
                    System.Console.Write("How many rounds? ");
                    int rounds = int.Parse(Console.ReadLine());
                    game.PlayRound(rounds, gameStyle);
                }
                else
                {
                    quit = true;
                }
            }
            
            game.Summary();
        }

        static int GetStock(string prodName)
        {
            int stock = -1;
            System.Console.Write($"Enter {prodName} quantity: ");
            do
            {
                stock = int.Parse(Console.ReadLine());
            } while(stock < 0);
            
            return stock;
        }
    }
}
