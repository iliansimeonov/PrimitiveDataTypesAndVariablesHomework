//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;
class AssignNullValues
{
    static void Main()
    {
        int? emptyInt = null;
        double? emptyDouble = null;
        Console.WriteLine("{0} {1}", emptyInt, emptyDouble);
        emptyInt += 5;
        emptyDouble += 7;
        Console.WriteLine("{0} {1}", emptyInt, emptyDouble);
        emptyInt += null;
        emptyDouble += null;
        Console.WriteLine("{0} {1}", emptyInt, emptyDouble);

    }
}
