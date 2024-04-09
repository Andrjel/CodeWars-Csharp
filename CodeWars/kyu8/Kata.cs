namespace CodeWars.kyu8;

public class Kata
{
   #region Square(n) Sum
   
   public static int SquareSum(int[] numbers)
   { 
      return numbers.Select(n => n*n).Sum();
   }

   #endregion 
}