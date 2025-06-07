using System.Text.RegularExpressions;

namespace WordFrequencyCounter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine()!;

        string cleanedInput = NormalizeText(input);

        string[] words = cleanedInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }

    static string NormalizeText(string text)
    {
        text = text.ToLower();

        text = Regex.Replace(text, @"[^\w\s]", "");

        return text;
    } 
}
