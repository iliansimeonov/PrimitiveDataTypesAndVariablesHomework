﻿//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;
class DeclareVariables
{
    static void Main()
    {
        byte byteNumber = 97;
        sbyte sbyteNumber = -115;
        ushort ushortNumber = 52130;
        short shortNumber = -1000;
        uint uintNumber = 4825932;

        Console.WriteLine(byteNumber + "\n" + sbyteNumber + "\n" + ushortNumber + "\n" + shortNumber + "\n" + uintNumber);
        Console.ReadLine();
    }
}