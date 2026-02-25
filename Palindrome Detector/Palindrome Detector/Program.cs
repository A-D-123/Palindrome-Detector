using System.Text.RegularExpressions;

namespace Palindrome_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or phrase to detect if it is a palindrome");
            String ogWord = Console.ReadLine();

            String word = Regex.Replace(ogWord, "[^a-zA-Z0-9]", "").ToLower();
            
            char[] letters = word.ToCharArray();
            Array.Reverse(letters);

            String rWord = new String(letters);

            if (word == rWord)
            {
                Console.WriteLine($"'{ogWord}' is a palindrome");
            }
            else
            {
                Console.WriteLine($"'{ogWord}' is not a palindrome");
            } 

            Console.ReadKey();
        }
    }
}
