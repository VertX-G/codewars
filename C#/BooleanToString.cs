/*
Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
*/

// My solution

using System;
using System.Linq;

public static class MyKata
{
  public static string boolToWord(bool word)
  {
    string answer = null;
    if (word == true)
      answer = "Yes";
    else if (word == false)
      answer = "No";
    return answer;
  }
}


// Voted best solution

public static class BestKata
{
  public static string boolToWord(bool word)
  {
    return word ? "Yes" : "No";
  }
}
