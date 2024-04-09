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
}