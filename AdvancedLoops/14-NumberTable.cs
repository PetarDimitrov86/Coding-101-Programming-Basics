using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write("{0} ", counter);
                counter++;
                if (counter > n)
                {
                    break;}
            }
            counter = n;
            while (counter + row > n + 1)
            {
                counter--;
                Console.Write("{0} ", counter);
            }
                counter = row + 1;
            Console.WriteLine();
        }
    }
}
