//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.

using System;
class FillEmployeeData
{
    static void Main()
    {
        Console.Write("Please enter your first name:");
        string firstName = Console.ReadLine();
        Console.Write("Please enter your last name:");
        string lastName = Console.ReadLine();
        Console.Write("Please enter your age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Are you male or female:");
        string gender = Console.ReadLine();
        Random rNumber = new Random();
        int newIDNumber = rNumber.Next(0, 999999999);
        int employeeNumber = rNumber.Next(27560000, 27569999);
        Console.WriteLine(firstName + " " + lastName + "\n" + "Age: " + age + " ; " + gender + "\n"
        + "Your personal ID number is " + newIDNumber + "\n" + @"Your ENumber (Employee Number) is: " + employeeNumber);
    }
}
