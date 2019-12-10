using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {

    bool isItPalindrome(string str)
    {
    double halve = str.Length / 2;
    double finalHalve = Math.Floor(halve);
    

   for (int i = 0; i <= finalHalve; i++)
   {
       int finalLetter = str.Length - (1 + i);
       if (str[i] != str[finalLetter])
       {
         return false;
       }
    }
    return true;
    }

    Console.WriteLine("Enter a word to see if it's a palindrome!");
    string input = Console.ReadLine();
    Console.WriteLine(isItPalindrome(input));
    
}
}