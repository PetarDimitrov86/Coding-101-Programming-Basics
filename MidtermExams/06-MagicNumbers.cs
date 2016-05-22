using System;
class Program
{
    static void Main(string[] args)
    {
        int magicNumber = int.Parse(Console.ReadLine());
        for (int firstDigit = 1; firstDigit < 10; firstDigit++)
            for (int secondDigit = 1; secondDigit < 10; secondDigit++)
                for (int thirdDigit = 1; thirdDigit < 10; thirdDigit++)
                    for (int fourthDigit = 1; fourthDigit < 10; fourthDigit++)
                        for (int fifthDigit = 1; fifthDigit < 10; fifthDigit++)
                            for (int sixthDigit = 1; sixthDigit < 10; sixthDigit++)
                                if (firstDigit * secondDigit * thirdDigit * fourthDigit * fifthDigit * sixthDigit == magicNumber)
                                {
                                    Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit}{fifthDigit}{sixthDigit} ");
                                }
    }
}
