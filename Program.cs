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
                // Checks if current char is a digit, otherwise moves to the next one
                if (char.IsDigit(mainString[i]))
                {
                    // Sets the current number and searches for the next one as well
                    char currentNumber = mainString[i];
                    int nextIndex = mainString.IndexOf(currentNumber, i + 1);

                    // nextIndex becomes -1 by default if it can't find the next index
                    if (nextIndex != -1)
                    {
                        // Cuts mainString up into 3 different substrings, the ones in the middle are red
                        string firstSub = mainString.Substring(0, i);
                        string redSub = mainString.Substring(i, nextIndex);
                        string lastSub = mainString.Substring(i + redSub.Length);

                        // Puts all three substrings together, with ANSI escape characters in between that changes the color to red
                        string totalString = firstSub + "\u001b[31m" + redSub + "\u001b[0m" + lastSub;

                        Console.WriteLine(totalString);
                    }
                }
            }
        }
    }
}
