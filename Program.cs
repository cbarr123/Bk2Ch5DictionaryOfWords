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
            foreach(KeyValuePair<string, string> word in wordsAndDefinitions) 
            {
               Console.WriteLine($"The definition of {word.Key} is {word.Value}."); 
            }

            // Make a new list 
            Console.WriteLine(); 

            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>() 
            {
                new Dictionary<string, string> (){
                    {"word", "excited"},
                    {"definition", "heightened state of energy"},
                    {"Part of speech", "adjective"},
                    {"example", "I am excited to learn C#"}
                },
                new Dictionary<string, string> () {
                    {"word", "nervous"},
                    {"wordsAndDefinitions", "heightened state of anxiety"},
                    {"part of speech", "adjective"}, 
                    {"example", "I am nervous about not being in school today"}
                }
            };

            foreach (Dictionary<string,string> word in dictionaryOfWords)
                {
                    foreach (KeyValuePair<string, string> kvp in word)
                        {
                            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                        }
                }



        }
    }
}
