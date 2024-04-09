using NUnit.Framework;

namespace CodeWars.kyu6;

[TestFixture]
public class Tests
{
    #region Create Phone Number

    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
    [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
    public static string FixedTest(int[] numbers)
    {
        return Kata.CreatePhoneNumber(numbers);
    }

    #endregion

    #region Count Words GAME!

    // [Test]
    // public void Test1()
    // {
    //     Assert.AreEqual("Dom 12", Kata.CountSubstringsGame("BANANA"));
    // }
    //
    // [Test]
    // public void Test2()
    // {
    //     Assert.AreEqual("Sara 19", Kata.CountSubstringsGame("BAANANAS"));
    // }
    //
    // [Test]
    // public void Test3()
    // {
    //     Assert.AreEqual("Draw", Kata.CountSubstringsGame("BANAASA"));
    // }

    #endregion

    #region Is a number prime?

    private static IEnumerable<TestCaseData> sampleTestCases
    {
        get
        {
            yield return new TestCaseData(0).Returns(false);
            yield return new TestCaseData(1).Returns(false);
            yield return new TestCaseData(2).Returns(true);
            yield return new TestCaseData(4).Returns(false);
        }
    }

    [Test, TestCaseSource("sampleTestCases")]
    public bool SampleTest(int n) => Kata.IsPrime(n);

    #endregion

    #region Stop gninnipS My sdroW!

    [Test]
    public static void Test1()
    {
        Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
    }
  
    [Test]
    public static void Test2()
    {  
        Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
    }
  
    [Test]
    public static void Test3()
    {
        Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
    }
  
    [Test]
    public static void Test4()
    {
        Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
    }
  
    [Test]
    public static void Test5()
    {
        Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
    }
  
    [Test]
    public static void Test6()
    {
        Assert.AreEqual("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));
    }

    #endregion

    #region Counting Duplicates

    [Test]
    public void KataTests()
    {
        Assert.AreEqual(0, Kata.DuplicateCount(""));
        Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
        Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
        Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
        Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
        Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
    }

    #endregion
}