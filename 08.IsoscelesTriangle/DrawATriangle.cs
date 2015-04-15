using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        char symbol = '\u00a9';
        Console.WriteLine("   {0}", symbol);
        Console.WriteLine();
        Console.WriteLine("  {0} {0}", symbol);
        Console.WriteLine();
        Console.WriteLine(" {0}   {0}", symbol);
        Console.WriteLine();
        Console.WriteLine("{0} {0} {0} {0} ", symbol);
    }
}

//Advanced Solving
//Console.OutputEncoding = System.Text.Encoding.Unicode;
//char ch = '\u00A9';
//Console.Write("Please enter desired hight:");
//int height = int.Parse(Console.ReadLine());
//int buffer = height - 1;
//int colCount = (height * 2) - 1;
//for (int cntRow = 0; cntRow < height; cntRow++)
//{
//    for (int cntCol = 1; cntCol <= colCount; cntCol++)
//    {
//        if (cntRow < (height - 1))
//        {
//            if (cntCol == (colCount - buffer) || cntCol == (buffer + 1))
//            {
//                Console.Write(ch);
//            }
//            else
//            {
//                Console.Write(" ");
//            }
//        }
//        else
//        {
//            Console.Write(cntCol % 2 == 0 ? " " : "{0}", ch);
//        }
//    }
//    buffer--;
//    Console.WriteLine();
//}