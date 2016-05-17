using System;
class Triangleof55stars
{
    static void Main()
    {
        for (int i = 0; i < 11; ++i)
        {
            string asterisks = new string('*', i);          //стринга получава прогресивно нови стойности спрямо i до края на for цикъла
            Console.WriteLine(asterisks);
        }
    }
}