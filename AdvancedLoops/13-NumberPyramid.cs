using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("{0} ", counter);
                counter++;
                if (counter == n + 1)
                {
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine();           
        }
    }
}
