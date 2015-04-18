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
        string holderNames = "Fisrt\\Middle\\Last";
        decimal balance = 5557.00M;
        string bankName = "Some Bank";
        string iBan = "Some Alphanumeric Data";
        long cardOneNumber = 132165165156165163L;
        long cardTwoNumber = 1615616646546645646L;
        long cardThreeNumber = 15655655444455555L;
        Console.WriteLine(holderNames + "\n" + balance + "\n" + bankName + "\n" + iBan + "\n" + cardOneNumber + "\n" + cardTwoNumber + "\n" + cardThreeNumber);
    }
}