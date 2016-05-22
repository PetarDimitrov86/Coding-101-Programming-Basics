using System;
class Program
{
    static void Main(string[] args)
    {
        string animal = Console.ReadLine();
        string result = String.Empty;
        switch (animal)
        {
            case "dog":
                result = "mammal";
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                result = "reptile";
                break;
            default:
                result = "unknown";
                break;
        }
        Console.WriteLine(result);
    }
}
