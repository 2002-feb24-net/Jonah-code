using System;

namespace collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while(n != 1) {
                if(n%2 == 0) {
                n /= 2;
                }
                else {
                    n = (n*3)+1;
                }
                System.Console.WriteLine(n);
            }
        }
    }
}
