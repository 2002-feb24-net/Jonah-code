using System;

namespace acronymcreator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input a term/phrase.");
            string phrase = getPhrase();
            System.Console.WriteLine($"The acronym for this term/phrase is: {createAcronym(phrase)}");
        }

        static string getPhrase()
        {
            return Console.ReadLine();
        }

        static string createAcronym(string s)
        {
            string[] term = s.Split(' ');
            string Acronym = "";
            foreach (string item in term)
            {
                Acronym += item[0].ToString().ToUpper();
            } 
            return Acronym;
        }
    }
}
