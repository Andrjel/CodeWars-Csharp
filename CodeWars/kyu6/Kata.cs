using System.Runtime.CompilerServices;
using NUnit.Framework.Constraints;

namespace CodeWars.kyu6;

public class Kata
{
    #region Create Phone Number

    public static string CreatePhoneNumber(int[] numbers)
    {
        var stringNumbers = numbers.Select(n => n.ToString()).ToList();
        stringNumbers.Insert(3, ") ");
        stringNumbers.Insert(0, "(");
        stringNumbers.Insert(stringNumbers.Count - 4, "-");
        return String.Join("", stringNumbers);
    }

    #endregion

    #region Count Words GAME!

    public static string CountSubstringsGame(string word)
    {
        var vowels = "aeiouAEIOU";
        var saraWords = new Dictionary<string, int>();
        var domWords = new Dictionary<string, int>();
        var n = word.Length;
        var temp = new List<char>();
        
        for (int len = 1; len <= n; len++)
        {
            for (int i = 0; i <= n - len; i++)
            {
                int j = i + len - 1;
                for (int k = i; k <= j; k++)
                    temp.Add(word[k]);
                var resultWord = String.Join("", temp);
                int currentCount;
                if (vowels.IndexOf(resultWord[0]) >= 0)
                {
                    saraWords.TryGetValue(resultWord, out currentCount);
                    saraWords[resultWord] = currentCount + 1;
                }
                else
                {
                    domWords.TryGetValue(resultWord, out currentCount);
                    domWords[resultWord] = currentCount + 1; 
                }
                temp.Clear();
            }
        }

        var domResults = domWords.Values.Sum();
        var saraResults = saraWords.Values.Sum();

        if (domResults > saraResults)
        {
            return $"Dom {domResults}";
        }

        if (saraResults > domResults)
        {
            return $"Sara {saraResults}";
        }

        return "Draw";
    }

    #endregion

    #region Is a number prime?
    
    public static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }
        var i = 2;
        var is_prime = true;
        while (i <= Math.Sqrt(n))
        {
            if (n % i == 0)
            {
                return false;
            }
            i++;
        }
        return true;
    }

    #endregion

    #region Stop gninnipS My sdroW!

    public static string SpinWords(string sentence)
    {
        return String.Join(' ', sentence.Split().Select(word => word.Length > 4 ? String.Join("", word.Reverse()) : word));
    }

    #endregion

    #region Counting Duplicates

    public static int DuplicateCount(string str)
    {
        var duplicates = new Dictionary<char, int>();
        foreach (var letter in str.ToLower())
        {
            duplicates.TryGetValue(letter, out int actValue);
            duplicates[letter] = actValue + 1;
        }
        return duplicates.Values.Sum(x => x > 1? 1 : 0);
    }

    #endregion

    #region Multiples of 3 or 5

    public static int Solution(int value)
    {
        if (value < 0)
            return 0;
        return Enumerable.Range(0, value).Select(num => num % 3 == 0 || num % 5 == 0 ? num : 0).Sum();
    }

    #endregion

    #region Convert string to camel case

    public static string ToCamelCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;
        return string.Concat(str[0] + string.Join("", str.Split('-', '_').Select(word => char.ToUpper(word[0]) + word[1..]))[1..]);
    }

    #endregion

    #region Multiplication table

    public static int[,] MultiplicationTable(int size)
    {
        var result = new int[size, size];
        for (var i = 1; i <= size; i++)
            for (var j = 1; j <= size; j++)
            {
                result[i - 1, j - 1] = i * j;
            }
        return result;
    }

    #endregion

    #region Decode the Morse code

    private static readonly Dictionary<string, char> MorseCode = new Dictionary<string, char>()
    {   
        { ".-", 'A' },
        { "-...", 'B' },
        { "-.-.", 'C' },
        { "-..", 'D' },
        { ".", 'E' },
        { "..-.", 'F' },
        { "--.", 'G' },
        { "....", 'H' },
        { "..", 'I' },
        { ".---", 'J' },
        { "-.-", 'K' },
        { ".-..", 'L' },
        { "--", 'M' },
        { "-.", 'N' },
        { "---", 'O' },
        { ".--.", 'P' },
        { "--.-", 'Q' },
        { ".-.", 'R' },
        { "...", 'S' },
        { "-", 'T' },
        { "..-", 'U' },
        { "...-", 'V' },
        { ".--", 'W' },
        { "-..-", 'X' },
        { "-.--", 'Y' },
        { "--..", 'Z' },
        { "-----", '0' },
        { ".----", '1' },
        { "..---", '2' },
        { "...--", '3' },
        { "....-", '4' },
        { ".....", '5' },
        { "-....", '6' },
        { "--...", '7' },
        { "---..", '8' },
        { "----.", '9' },
        { ".-.-.-", '.' },
        { "--..--", ',' },
        { "..--..", '?' },
        { ".----.", '\'' },
        { "-.-.--", '!' },
        { "-..-.", '/' },
        { "-.--.", '(' },
        { "-.--.-", ')' },
        { ".-...", '&' },
        { "---...", ':' },
        { "-.-.-.", ';' },
        { "-...-", '=' },
        { ".-.-.", '+' },
        { "-....-", '-' },
        { "..--.-", '_' },
        { ".-..-.", '\"' },
        { "...-..-", '$' },
        { ".--.-.", '@' },
        { "/", ' ' }
    };
    
    public static string MorseDecode(string morseCode)
    {
        var morseWords = morseCode.Split("   ");
        var result = new List<string>();
        foreach (var morseWord in morseWords)
        {
            var temp = string.Join("", morseWord.Split()
                .Select(word => MorseCode.TryGetValue(word, out char letter) ? letter.ToString() : ""));
            result.Add(temp);
        }

        return string.Join(" ", result);
    }

    #endregion
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}