/*
Write a function that takes a string of parentheses,
and determines if the order of the parentheses is valid.
The function should return true if the string is valid,
and false if it's invalid.

Examples
"()"              =>  true
")(()))"          =>  false
"("               =>  false
"(())((()())())"  =>  true
Constraints
0 <= input.length <= 100

Along with opening (() and closing ()) parenthesis,
input may contain any valid ASCII characters.
Furthermore, the input string may be empty and/or
not contain any parentheses at all.
Do not treat other forms of brackets as parentheses (e.g. [], {}, <>).
*/

/* -------------------- My solution -------------------- */

using System.Text.RegularExpressions;

public class Parentheses
{
  public static bool ValidParentheses(string input)
  {
    // first strip all characters except parentheses
    input = Regex.Replace(input, "[^()]", "");
    
    // if the string is now empty, there are no parentheses to check
    if(input.Length != 0) {
      string s;
      
      // loop through string and remove all valid open and closing parentheses
      do {
        s = input;
        input = Regex.Replace(input, "\\(\\)", "");
      } while (input.Length != s.Length);
      
      // if the string is now empty, all parentheses were valid
      if(input.Length == 0) {
        return true;
      }
    }
    return false;
  }
}


/* -------------------- Voted best solution -------------------- */

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        int parentheses = 0;
        foreach (char t in input)
        {
            if (t == '(')
            {
                parentheses++;
            }
            else if (t == ')')
            {
                parentheses--;

                if (parentheses < 0)
                {
                    return false;
                }
            }
        }

        return parentheses == 0;
    }
}
