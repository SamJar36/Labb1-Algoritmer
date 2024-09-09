using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a bunch of numbers");
        string text = Console.ReadLine();
        FindSequenceOfNumbersAndTurnRed(text);

        static void FindSequenceOfNumbersAndTurnRed(string mainString)
        {
            char[] charsArray = mainString.ToCharArray();
            int[] redArray = new int[mainString.Length];

            foreach (char c in charsArray)
            {
                if (char.IsDigit(c))
                {
                
                }
            }
        }
    }
}
