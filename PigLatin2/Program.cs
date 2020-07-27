using System;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Security.Authentication;

namespace PigLatin2
{
    class Program
    {
        public static bool IsVowel(char vowel)
        {
            if (vowel == 'a'|| vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public static string PigLatin(string word)
        {
            string consonantBeforeVowel = "";
            string translatedWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                if (IsVowel(currentLetter))
                {
                    if (i == 0)
                    {
                        translatedWord = word + "way";
                    }
                    else
                    {
                        word = word.Replace(consonantBeforeVowel, "");
                        translatedWord = word + consonantBeforeVowel + "ay";
                    }

                    break;
                }
                else
                {
                    consonantBeforeVowel = consonantBeforeVowel + currentLetter;
                }
            }
            return translatedWord;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welome to the Pig Ltin Translator!");

            bool lContinue = true;
            while (lContinue)
            {
                Console.WriteLine("Please enter a word.");
                string input = Console.ReadLine();
                input = input.ToLower();
                Console.WriteLine(PigLatin(input));

                Console.WriteLine("Would you like to translate another word? y/n");
                string input2 = Console.ReadLine();
                if (input2 == "y")
                {
                    lContinue = true;
                }
                else
                {
                    lContinue = false;
                    Console.WriteLine("Come again!");
                }
            }
        }
    }
}
