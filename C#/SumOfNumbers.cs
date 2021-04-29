/*
Given two integers a and b, which can be positive or negative,
find the sum of all the integers between including them too and return it.
If the two numbers are equal return a or b.

Note: a and b are not ordered!
*/

/* -------------------- My solution -------------------- */

using System;
public class Sum
{
   public int GetSum(int a, int b)
   {
     int[] num = {a,b};
     Array.Sort(num);
     int sum = num[0];
     while (num[0] < num[1]) {
       sum += (num[0]+=1);
     }
     return sum;
   }
}


/* -------------------- Voted best solution -------------------- */

using System;

public class Sum
{
  public int GetSum(int a, int b)
  {
    return (a + b) * (Math.Abs(a - b) + 1) / 2;
  }
}
