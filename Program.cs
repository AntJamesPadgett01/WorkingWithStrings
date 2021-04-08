using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey\nBuddy!");// \n starts text on the next line

            Console.WriteLine("Hey\" Buddy");// \" adds " between words

            string phrase = "Hey Buddy";
                          ///012345678 - index positions
            Console.WriteLine(phrase);
            Console.WriteLine( phrase.Length);// dot notation
            Console.WriteLine( phrase.ToLower());
            Console.WriteLine(phrase.Contains("Hey"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Buddy"));
            Console.WriteLine(phrase.Substring(5, 3));
                                            
        }
    }
}
