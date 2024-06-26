using System;
using System.Text.RegularExpressions;

namespace Day05_Assignment02;

public static class ExtrctPalindromes
{
    public static void ExtrctPalin()
    {
        string input = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";

        var palindromes = ExtractPalindromes(input);

        Console.WriteLine(string.Join(", ", palindromes));
    }

    static List<string> ExtractPalindromes(string text)
    {
        // Regex to match words
        string pattern = @"\b\w+\b";
        var matches = Regex.Matches(text, pattern);

        // HashSet to store unique palindromes
        HashSet<string> palindromes = new HashSet<string>();

        foreach (Match match in matches)
        {
            string word = match.Value;
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        // Convert to list and sort
        List<string> sortedPalindromes = palindromes.ToList();
        sortedPalindromes.Sort();

        return sortedPalindromes;
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}