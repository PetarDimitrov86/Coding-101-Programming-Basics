using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (Palindrome(i) == true && (SumOfDigits(i)) % 7 == 0 && OneEvenDigit(i) == true)
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool Palindrome(int n)
    {
        int counter = 0;
        string numText = "" + n;
        for (int i = 0; i < numText.Length / 2; i++)
        {
            if (numText[i] == numText[numText.Length - i - 1])
                counter++;
        }
        if (counter == numText.Length/2)
        {
            return true;
        }
        return false;
    }
    static int SumOfDigits(int n)
    {
        int sumDigits = 0;
        while (n > 0)
        {
            sumDigits += n % 10;
            n = n / 10;
        }
        return sumDigits;
    }
    static bool OneEvenDigit(int n)
    {
        string numText = "" + n;
        for (int i = 0; i < numText.Length; i++)
        {
            int digit = (int)numText[i];
            if (digit % 2 == 0)
                return true;
        }
        return false;
    }
}
