using System;

namespace secondstoyears
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSec = Console.ReadLine();
            long sec = long.Parse(strSec);
            double years = CalculateDays((double)sec);

            System.Console.WriteLine($"{sec}s = {years:0.000000} Earth years");
            System.Console.WriteLine($"{sec}s = {495.0 * years:0.000000} Mercury years");
            System.Console.WriteLine($"{sec}s = {193.8 * years:0.000000} Venus years");
            System.Console.WriteLine($"{sec}s = {53.3 * years:0.000000} Mars years");
            System.Console.WriteLine($"{sec}s = {10.05 * years:0.000000} Jupiter years");
            System.Console.WriteLine($"{sec}s = {4.04 * years:0.000000} Saturn years");
            System.Console.WriteLine($"{sec}s = {1.41 * years:0.000000} Uranus years");
            System.Console.WriteLine($"{sec}s = {0.72 * years:0.000000} Neptune years");
            System.Console.WriteLine($"{sec}s = {0.479 * years:0.000000} Pluto years");
        }
        static double CalculateDays(double n)
        {
            double min = n / 60.0;
            double hours = min / 60.0;
            double days = hours / 24.0;
            return days / 365.0;
        }
    }

}
