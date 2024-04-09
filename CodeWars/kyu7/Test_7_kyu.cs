using NUnit.Framework;

namespace CodeWars.kyu7;

[TestFixture]
public class Test_7_kyu
{
    #region Jaden Casing Strings

    [Test]
    public void FixedTest()
    {
        Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
            "How can mirrors be real if our eyes aren't real".ToJadenCase(),
            "Strings didn't match.");
    }

    #endregion

    #region You're square

    [Test]
    public static void ShouldWorkForSomeExamples()
    {
        Assert.AreEqual(false, Kata.IsSquare(-1),"negative numbers aren't square numbers");
        Assert.AreEqual(false, Kata.IsSquare(3),"3 isn't a square number");
        Assert.AreEqual(true, Kata.IsSquare(4),"4 is a square number");
        Assert.AreEqual(true, Kata.IsSquare(25),"25 is a square number");
        Assert.AreEqual(false, Kata.IsSquare(26),"26 isn't a square number");
    }

    #endregion

    #region Reverse words

    [Test]
    public void Example()
    {
        Assert.AreEqual("sihT si na !elpmaxe", Kata.ReverseWords("This is an example!"));
    }

    #endregion
} 