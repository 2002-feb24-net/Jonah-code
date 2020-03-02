using System;

namespace FizzBuzz
{
    class Program
    {
        // There are 267 Fizzes, 134 Buzzes, and 66 FizzBuzzes from 1 to 1000
        static void Main(string[] args)
        {
            int fCount = 0;
            int bCount = 0;
            int fbCount = 0;
            for (int i = 1; i < 1001; i++) {
                if(i%3 == 0 && i%5 != 0) 
                {
                    System.Console.Write("Fizz ");
                    fCount++;
                }
                else if(i%5 == 0 && i%3 != 0)
                {
                    System.Console.Write("Buzz ");
                    bCount++;
                }
                else if(i%3 == 0 && i%5 == 0)
                {
                    System.Console.Write("FizzBuzz ");
                    fbCount++;
                }
                else
                {
                    System.Console.Write($"{i} ");
                }
            }
            System.Console.WriteLine($"\nFizz count: {fCount}\nBuzz count: {bCount}\nFizzBuzz count: {fbCount}");
        }
    }
}
