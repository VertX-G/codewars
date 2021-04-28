/*
Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence,
which is the number of times you must multiply the digits in num until you reach a single digit.

For example:

 persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
                      // and 4 has only one digit
                 
 persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
                       // 1*2*6 = 12, and finally 1*2 = 2
                  
 persistence(4) == 0 // because 4 is already a one-digit number
*/

/* -------------------- My solution -------------------- */
using System;

public class Persist 
{
	public static int Persistence(long n) 
	{
    int count = 0, product = 1;
    string digits = n.ToString();
    
    // If 'n' has more than one digit it can be multiplied
    if (digits.Length > 1) {
      count++;
      
      // Get product of all digits of 'n'
      for (int i = 0; i < digits.Length; i++) {
        product *= int.Parse((digits[i]).ToString());
      }
      
      // Pass product back to function
      // to recursively count multiplicative persistence
      // and tally total 'count'
      return count += Persistence(product);
    }
    return count;
  }
}



/* -------------------- Voted best solution -------------------- */

using System;
using System.Linq;

public class Persist 
{
  public static int Persistence(long n)
  {
      int count = 0;
      while (n > 9)
      {
          count++;
          n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
      }
      return count;
  }
}
