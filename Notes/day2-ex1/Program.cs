using System;

namespace stair8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int k = 9-i; k > 0; k--) {
                    System.Console.Write(" ");
                }
                for (int j = i; j > 0; j--)
                {
                    System.Console.Write("#");
                }
                System.Console.WriteLine();
            }

            // Reverse array class excersise
            System.Console.Write("Please input a string: ");
            string array = Console.ReadLine();

            for (int z = array.Length-1; z >= 0; z--)
            {
                System.Console.Write(array[z]);
            }
            System.Console.WriteLine();
        }
    }
}
