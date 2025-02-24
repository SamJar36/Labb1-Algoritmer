using System;
using System.Numerics;
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
            List<BigInteger> numbers = new List<BigInteger>();
            Console.WriteLine();
            for (int startIndex = 0; startIndex < mainString.Length; startIndex++)
            {
                char startNumber = mainString[startIndex];
                
                if (char.IsDigit(startNumber))
                {
                    int nextIndex = mainString.IndexOf(startNumber, startIndex + 1);
                    int redLength = (nextIndex - startIndex) + 1;

                    if (nextIndex != -1)
                    {
                        bool hasLetters = false;
                        for (int j = startIndex + 1; j < nextIndex; j++)
                        {
                            char currentChar = mainString[j];
                            if (char.IsLetter(currentChar) || !char.IsLetterOrDigit(currentChar))
                            {
                                hasLetters = true;
                                break;
                            }
                        }
                        if (!hasLetters)
                        {
                            string firstSub = mainString.Substring(0, startIndex);
                            string redSub = mainString.Substring(startIndex, redLength);
                            string lastSub = mainString.Substring(startIndex + redSub.Length);
                            string totalString = firstSub + "\u001b[31m" + redSub + "\u001b[0m" + lastSub;

                            Console.WriteLine(totalString);


                            BigInteger parsedNumbers = BigInteger.Parse(redSub);
                            numbers.Add(parsedNumbers);

                        }           
                    }
                }          
            }
            BigInteger result = 0;
            foreach (BigInteger number in numbers)
            {
                result += (BigInteger)number;
            }
            Console.WriteLine();
            Console.WriteLine($"The total of all highlighted numbers are: {result}");
        }
    }
}
