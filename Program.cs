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

        Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordFrequencies.ContainsKey(word))
            {
                wordFrequencies[word]++;
            }
            else
            {
                wordFrequencies[word] = 1;
            }
        }

        Console.WriteLine("\nWord Frequencies:");
        foreach (var kvp in wordFrequencies)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    static string NormalizeText(string text)
    {
        text = text.ToLower();

        text = Regex.Replace(text, @"[^\w\s]", "");

        return text;
    } 
}
