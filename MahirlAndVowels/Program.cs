using System;

namespace MahirlAndVowels
{
    /// <summary>
    /// Main program class to process two input words by removing common consonants
    /// and then eliminating consecutive duplicate characters.
    /// </summary>
class Program
{
    static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        string step1Result = RemoveCommonConsonants(word1, word2);
        string finalResult = RemoveConsecutiveDuplicates(step1Result);

        Console.WriteLine(finalResult);
    }
    /// <summary>
    /// Removes consonants from word1 that are also present in word2, preserving vowels.
    /// </summary>
    /// <param name="word1">The first input word.</param>
    /// <param name="word2">The second input word.</param>
    /// <returns>A string with common consonants removed from word1.</returns>
    static string RemoveCommonConsonants(string word1, string word2)
    {
        string result = "";
        foreach (char c in word1)
        {
            char lowerChar = char.ToLower(c);
            if (IsVowel(lowerChar))
            {
                result += c;
            }
            else
            {
                if (!word2.ToLower().Contains(lowerChar))
                {
                    result += c;
                }
            }
        }
        return result;
    }
    /// <summary>
    /// Removes consecutive duplicate characters from the input word.
    /// </summary>
    /// <param name="word">The input word from which consecutive duplicates will be removed.</param>
    /// <returns>A string with consecutive duplicate characters removed.</returns>
    static string RemoveConsecutiveDuplicates(string word)
    {
        if (word.Length == 0)
            return word;
        string result = "";
        result += word[0];
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] != word[i - 1])
            {
                result += word[i];
            }
        }
        return result;
    }
    /// <summary>
    /// Checks if a character is a vowel.
    /// </summary>
    /// <param name="c">The character to check.</param>
    /// <returns>True if the character is a vowel; otherwise, false.</returns>
    static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
}