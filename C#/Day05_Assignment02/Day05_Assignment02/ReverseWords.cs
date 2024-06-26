using System;
using System.Text.RegularExpressions;

namespace Day05_Assignment02;

public static class ReverseWords
{ 
    public static void ReverseWord()
    {
        string input1 = "C# is not C++, and PHP is not Delphi!";
        string input2 = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/.";
        
        Console.WriteLine(Reverse(input1));
        Console.WriteLine(Reverse(input2));
        
    }

    static string Reverse(string sentence)
    {
        // Regex to match words and separators
        string pattern = @"(\b\w+[-\w+]*\b)|([.,:;=()&[\]""'\\\/!? ])";
        var matches = Regex.Matches(sentence, pattern);

        // Lists to store words and separators
        List<string> words = new List<string>();
        List<string> separators = new List<string>();

        foreach (Match match in matches)
        {
            if (match.Groups[1].Success) // word
            {
                words.Add(match.Value);
            }
            else if (match.Groups[2].Success) // separator
            {
                separators.Add(match.Value);
            }
        }

        // Reverse the list of words
        words.Reverse();

        // Build the result
        int wordIndex = 0, separatorIndex = 0;
        string result = "";

        foreach (Match match in matches)
        {
            if (match.Groups[1].Success) // word
            {
                result += words[wordIndex++];
            }
            else if (match.Groups[2].Success) // separator
            {
                result += separators[separatorIndex++];
            }
        }

        return result;
    }

}
