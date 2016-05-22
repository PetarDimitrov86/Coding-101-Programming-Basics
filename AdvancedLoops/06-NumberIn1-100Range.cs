using System;
    class Program
    {
    static void Main(string[] args)
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine(n);
                break;
            }
        }
    }
}
