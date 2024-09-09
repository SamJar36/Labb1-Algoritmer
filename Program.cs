using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a bunch of numbers");
        string text = Console.ReadLine();
        FindSequenceOfNumbersAndTurnRed(text);

        static void FindSequenceOfNumbersAndTurnRed(string mainString)
        {
            for (int i = 0; i < mainString.Length; i++)
            {
                if (char.IsDigit(mainString[i]))
                {
                    char currentNumber = mainString[i];
                    int nextIndex = mainString.IndexOf(currentNumber, i);

                    string firstSub = mainString.Substring(0, i);
                    string redSub = mainString.Substring(currentNumber, nextIndex);
                    string lastSub = mainString.Substring(nextIndex + redSub.Length);

                    string totalString = firstSub + "\u001b[31m" + redSub + "\u001b[0m" + lastSub;

                    Console.WriteLine(totalString);
                }
            }
        }
    }
}
