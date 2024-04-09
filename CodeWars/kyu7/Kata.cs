namespace CodeWars.kyu7;

public static class Kata
{
    #region Jaden Casing Strings

    public static string ToJadenCase(this string phrase)
    {
        var splitString = phrase.Split(' ');
        var capitalizedString =
            splitString.Select(word => String.Concat(word[0].ToString().ToUpper(), word.Substring(1)));
        return String.Join(' ', capitalizedString);
    }

    #endregion

    #region You're square

    public static bool IsSquare(int n)
    {
        switch (n)
        {
            case < 0:
                return false;
            case 0:
                return true;
        }

        var root = (int)Math.Sqrt(n);
        return root * root == n;
    }

    #endregion

    #region Reverse words

    public static string ReverseWords(string str)
    {
        var splitWords = str.Split(' ');
        return String.Join(' ', splitWords.Select(word => String.Join("", word.Reverse())));
    }

    #endregion
    
    
}