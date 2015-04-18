//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
////Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of 
//the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other 
//than a fixed constant eps.

using System;
using System.Globalization;
class CompareTwoFloats
{
    static void Main()
    {
        Console.WriteLine("Check if two numbers are equal (precision is 0.000001) \nPlease enter first number to compare: ");
        double numberA = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Please enter second number to compare: ");
        double numberB = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double eps = 0.000001;
        double diff = Math.Round((numberA - numberB), 6);
        Console.WriteLine("Difference is {0}", diff.ToString());
        if (Math.Abs(numberA-numberB) < eps)
        {
            Console.WriteLine("Numbers are equal");
        }
        else
        {
            Console.WriteLine("Numbers are not equal");
        }
    }
}

//if (numberA > numberB)
//        { 
//            diff = (numberA - numberB);
//            Console.WriteLine("The diference is {0}", diff);
//        } 
//        else if (numberB > numberA)
//        {
//            diff = (numberB - numberA);
//            Console.WriteLine("The diference is {0}", diff);
//        }