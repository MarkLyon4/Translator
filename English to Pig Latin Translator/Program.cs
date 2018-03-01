using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_to_Pig_Latin_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the English to Pig Latin word translator!  Enter a word to be translated or enter 1 to quit.");
            Console.WriteLine("Will not translate words with - or ' in them because those are just combinations of words.");
            string word = Console.ReadLine();
            while (word != "1")
            {
                string english = word;
                if (word.Contains("-") || word.Contains("'"))
                {
                    Console.WriteLine($"The pig latin translation of the word {english} is {word}.  Enter another word to be translated or enter 1 to quit.");
                    word = Console.ReadLine();
                    continue;
                }
                string start = "";
                int i = 0;
                while ("aeiouAEIOU".Contains(word[i]) == false)
                {
                    start += word[i];
                    word = word.Remove(0,1);
                    if (word.Length == 0)
                    {
                        break;
                    }
                }
                word += start;
                word += "ay";
                Console.WriteLine($"The pig latin translation of the word {english} is {word}.  Enter another word to be translated or enter 1 to quit.");
                word = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
        }
    }
}
