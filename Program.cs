using System;
using System.Collections.Generic;

namespace DictionaryOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
                    /*Create a dictionary with key value pairs to
            represent words (key) and its definition (value)*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Concerned", "The feeling of students when they don't understand C#");
            wordsAndDefinitions.Add("Hungry", "The feeling of students at 11:45");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            // Console.WriteLine(wordsAndDefinitions[1].Key);

            foreach(KeyValuePair<string, string> word in wordsAndDefinitions) 
            {
               Console.WriteLine($"The definition of {word.Key} is {word.Value} "); 
            }

        }
    }
}
