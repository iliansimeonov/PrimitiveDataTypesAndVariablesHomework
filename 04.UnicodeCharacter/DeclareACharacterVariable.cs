//Problem 4. Unicode Character

//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal)
//using the \u00XX syntax, and then print it.

using System;
class DeclareACharacterVariable
{
    static void Main()
    {
        int decValue = 42;
        string hexValue = decValue.ToString();
        char unicodeChar = Convert.ToChar(decValue);
        {
            Console.WriteLine("The hex representation of {0} is {1}, and the char for {1} is {2} ", decValue, hexValue, unicodeChar);
            Console.ReadLine();
        }
    }
}
