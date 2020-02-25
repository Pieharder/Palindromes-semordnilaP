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
    List<char> reverseList = new List<char>();
    for(int i = charArray.Length-1; i >= 0; i--)
    {
      reverseList.Add(charArray[i]);
    }
    char[] reverseArr = reverseList.ToArray();
    string reverseString = string.Join("", reverseArr);
    return reverseString;
  }
}