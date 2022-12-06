using System;
using System.Collections.Generic;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
    Console.WriteLine("Please enter a word");
    string userInput = Console.ReadLine();
    // Console.WriteLine(userInput);
    string reversed = "";
    
    // string[] array = userInput.Split(Char[]);
    char[] characters = userInput.ToCharArray();

    // List<char> charactersReverse = new List<char> {};

    for (int i = characters.Length -1; i >= 0; i--)
    {
      reversed = reversed + characters[i];
      // charactersReverse.Add(characters[i]);
    }
    // Console.WriteLine(reversed);
    
    if (userInput == reversed)
    {
      Console.WriteLine($"{reversed} is a Palindrome");
    } 
    else 
    {
      Console.WriteLine("Tis Not Palindrome"); 
    }
    }
  }
}
