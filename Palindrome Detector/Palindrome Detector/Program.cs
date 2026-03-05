using System.Text.RegularExpressions;

namespace Palindrome_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or phrase to detect if it is a palindrome");
            string word = Console.ReadLine();

            Console.Write($"'{word}'");

            word = Regex.Replace(word, "[^a-zA-Z0-9]", "").ToLower();

            string revWord = new string(word.Reverse().ToArray());

            if (word == revWord)
            {
                Console.WriteLine(" is a palindrome");
            }
            else
            {
                Console.WriteLine(" is not a palindrome");
            } 

            Console.ReadKey();
        }
    }
}
