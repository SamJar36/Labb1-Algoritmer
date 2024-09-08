using System;

Console.WriteLine("Enter a bunch of numbers");
string text = Console.ReadLine();
FindSequenceOfNumbersAndTurnRed(text);

static void FindSequenceOfNumbersAndTurnRed (string mainString)
{
    char[] charactersArray = mainString.ToCharArray();
    int[] redNumbersArray = new int[mainString.Length];

    foreach (char c in charactersArray)
    {  
        if (char.IsDigit(c))
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        Console.Write(c);
    }
}