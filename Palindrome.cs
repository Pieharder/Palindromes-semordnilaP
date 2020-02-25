using System;
using System.Collections.Generic;

class Palindromes
{
  public static void Main()
  {
    Console.WriteLine("Please enter a string:");
    string userString = Console.ReadLine();
    if(IsPalindrome(userString))
    {
      Console.WriteLine("Your string is a Palindrome!");
    }
    else{
      Console.WriteLine("Your string is not a Palindrome");
    }
  }
  public static bool IsPalindrome(string userString)
  {
    if(userString == reverseString(userString))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  public static string reverseString(string forwardString)
  {
    char[] charArray = forwardString.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
  }
}