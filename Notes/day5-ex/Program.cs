using System;

namespace acronymcreator
{
    class Program
    {
        //protected string phrase;

        static void Main(string[] args)
        {
            System.Console.WriteLine("Input a term/phrase.");
            string phrase = setPhrase();
            System.Console.WriteLine($"The acronym for this term/phrase is: {createAcronym(phrase)}");
        }

        static string setPhrase()
        {
            return Console.ReadLine();
        }

        //public string getPhrase()
        //{
        //    return phrase;
        //}

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
