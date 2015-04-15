//Problem 5. Boolean Variable

//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.

using System;
class DeclareBooleanVariable
{
    static void Main()
    {
        Console.Write("Is your gender female?");
        string gender = Console.ReadLine();
        bool isFemale = gender=="no";
        {
            Console.WriteLine(isFemale);
        }
    }
}