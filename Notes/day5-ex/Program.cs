using System;

namespace acronymcreator
{
    class Program
    {
        protected string phrase;

        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input a term/phrase.");
            Program Acro = new Program();
            System.Console.WriteLine($"The acronym for this term/phrase is: {Acro.createAcronym()}");
        }

        public Program()
        {
            setPhrase();
        }

        protected void setPhrase()
        {
            phrase = Console.ReadLine();
        }

        protected void setPhrase(string s)
        {
            phrase = s;
        }

        public string getPhrase()
        {
            return phrase;
        }

        public string createAcronym(string s)
        {
            string[] term = s.Split(' ');
            string Acronym = "";
            foreach (string item in term)
            {
                Acronym += item[0].ToString().ToUpper();
            } 
            return Acronym;
        }

        public string createAcronym()
        {
            string[] term = phrase.Split(' ');
            string Acronym = "";
            foreach (string item in term)
            {
                Acronym += item[0].ToString().ToUpper();
            } 
            return Acronym;
        }
    }
}
