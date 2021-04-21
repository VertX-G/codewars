/*
Some numbers have funny properties. For example:
89 --> 8¹ + 9² = 89 * 1
695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2
46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51

Given a positive integer n written as abcd... (a, b, c, d... being digits) and a positive integer p
we want to find a positive integer k, if it exists, such as the sum of the digits of n taken to the successive powers of p is equal to k * n.

In other words:
Is there an integer k such as : (a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ...) = n * k
If it is the case we will return k, if not return -1.
Note: n and p will always be given as strictly positive integers.
*/

// My solution

using System;
using System.Collections.Generic;

public class DigPow {
	public static long digPow(int n, int p) {
		
    long newN = n;
    List<long> digits = new List<long>();
    int count = 0;
    long sum = 0;
    
    do
    {
      digits.Add(newN % 10);
    }
    while ((newN /= 10L) != 0L);
    
    digits.Reverse();
    
    foreach(int digit in digits)
    {
      sum += Convert.ToInt64(Math.Pow(digit,p+count));      
      count++;
    }

    if (sum % n == 0)
    {
      return(sum / n);
    }
    else
    {
      return -1;
    }
	}
}
