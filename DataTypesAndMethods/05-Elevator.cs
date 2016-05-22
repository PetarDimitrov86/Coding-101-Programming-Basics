using System;
class Program
{
    static void Main(string[] args)
    {
        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());
        double peoplePerCourse = (double) people / capacity;
        Console.WriteLine(Math.Ceiling(peoplePerCourse));
    }
}
