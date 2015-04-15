//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;
class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Integer a = " + a + " " + "and integer b = " + b);
        a = a + b; //15
        b = a - b; //5
        a = a - b; //10
        Console.WriteLine("after the exchange integer a = " + a + " " + "and integer b = " + b);

    }
}