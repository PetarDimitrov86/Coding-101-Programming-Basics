using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool[] numbers = new bool[n + 1];
        for (int index = 2; index <= n; index++)
        {
            numbers[index] = true;       
        }

        for (int i = 2; i <= n; i++)
        {
            if (numbers[i])
            {
                Console.WriteLine(i);
                int start = 2 * i;
                while (start <= n)
                {
                    numbers[start] = false;
                    start = start + i;
                }
            }
        }
    }
}
