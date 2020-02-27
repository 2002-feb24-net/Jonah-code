using System;

namespace stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int k = n-i; k > 0; k--) {
                    System.Console.Write(" ");
                }
                for (int j = i; j > 0; j--)
                {
                    System.Console.Write("#");
                }
                System.Console.WriteLine();
            }
        }
    }
}
