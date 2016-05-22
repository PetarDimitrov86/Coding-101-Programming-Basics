using System;
class RectangleWithStars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int rows = n - 1;
        if (n % 2 == 1)
            rows = n;
        Console.WriteLine(new string('%', 2 *n));
        for (int row = 1; row <= rows; row++)
        {
            Console.Write("%");
            Console.Write(new string(' ', n - 2));
            if ((rows + 1)/ 2 == row)
                Console.Write("**");
            else
                Console.Write("  ");
            Console.Write(new string(' ', n - 2));
            Console.WriteLine("%");
        }
        Console.WriteLine(new string('%', 2 * n));
    }
}
