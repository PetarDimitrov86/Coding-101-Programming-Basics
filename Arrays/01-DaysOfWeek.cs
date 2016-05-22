using System;
class Program
{
    static void Main(string[] args)
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int n = int.Parse(Console.ReadLine());
        if (n > 0 && n < 8)
            Console.WriteLine(days[n-1]);
        else
            Console.WriteLine("Invalid day!");
    }
}
