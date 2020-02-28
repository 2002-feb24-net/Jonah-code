using System;

namespace acronymcreator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Input a term/phrase.");
            string phrase = getPhrase();
        }

        public string getPhrase()
        {
            return Console.Readline();
        }

        public void makeAcronym()
        {

        }
    }
}
