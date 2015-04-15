//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types 
//and descriptive names.

using System;
class FillBankData
{
    static void Main()
    {
        string holderNames = null;
        long balance = 0L;
        string bankName = null;
        string iBan = null;
        long cardOneNumber = 0L;
        long cardTwoNumber = 0L;
        long cardThreeNumber = 0L;
        Console.WriteLine(holderNames + "\n" + balance + "\n" + bankName + "\n" + iBan + "\n" + cardOneNumber + "\n" + cardTwoNumber + "\n" + cardThreeNumber);
    }
}