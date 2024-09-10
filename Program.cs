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
            List<ulong> numbers = new List<ulong>();
            Console.WriteLine();
            for (int i = 0; i < mainString.Length; i++)
            {
                if (char.IsDigit(mainString[i]))
                {
                    char currentNumber = mainString[i];
                    int nextIndex = mainString.IndexOf(currentNumber, i + 1);
                    int redLength = (nextIndex - i) + 1;

                    if (nextIndex != -1)
                    {
                        bool hasLetters = false;
                        for (int j = i + 1; j < nextIndex; j++)
                        {
                            
                            if (char.IsLetter(mainString[j]) || !char.IsLetterOrDigit(mainString[j]))
                            {
                                hasLetters = true;
                                break;
                            }
                        }
                        if (!hasLetters)
                        {
                            string firstSub = mainString.Substring(0, i);
                            string redSub = mainString.Substring(i, redLength);
                            string lastSub = mainString.Substring(i + redSub.Length);
                            string totalString = firstSub + "\u001b[31m" + redSub + "\u001b[0m" + lastSub;

                            Console.WriteLine(totalString);

                            ulong parsedNumbers = UInt64.Parse(redSub);
                            numbers.Add(parsedNumbers);
                        }           
                    }
                }          
            }
            ulong result = 0;
            foreach (ulong number in numbers)
            {
                result += (ulong)number;
            }
            Console.WriteLine();
            Console.WriteLine($"The total of all highlighted numbers are: {result}");
        }
    }
}
