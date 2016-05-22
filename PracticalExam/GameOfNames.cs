using System;
class GameOfNames
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string result = string.Empty;
        int maxScore = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            int score = int.Parse(Console.ReadLine());
            int nameScore = 0;
            for (int j = 0; j < name.Length; j++)
            {
                if (name[j] % 2 == 0)
                    nameScore += name[j];
                else
                    nameScore -= name[j];
            }
            nameScore += score;
            if (nameScore > maxScore)
            {
                result = name;
                maxScore = nameScore;
            }
        }
        Console.WriteLine("The winner is {0} - {1} points", result, maxScore);
    }
}
