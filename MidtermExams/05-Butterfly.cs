using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int width = 2 * n - 1;
        int heigth = 2 * (n - 2) + 1;
        int leftRightWing = n - 1;
        
        for (int i = 0; i < (2*(n - 2) + 1) / 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(new string('*', n - 2));
                Console.Write("\\ /");
                Console.WriteLine(new string('*', n - 2));
            }
            else
            {
                Console.Write(new string('-', n - 2));
                Console.Write("\\ /");
                Console.WriteLine(new string('-', n - 2));
            }
        }
 
        Console.Write(new string(' ', n - 1));
        Console.Write("@");
        Console.WriteLine(new string(' ', n - 1));

        for (int i = 0; i < (2 * (n - 2) + 1) / 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(new string('*', n - 2));
                Console.Write("/ \\");
                Console.WriteLine(new string('*', n - 2));
            }
            else
            {
                Console.Write(new string('-', n - 2));
                Console.Write("/ \\");
                Console.WriteLine(new string('-', n - 2));
            }
        }
    }
}
