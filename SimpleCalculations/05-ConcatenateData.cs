using System;
class ConcatenateData
{
    static void Main()
    {
        Console.Write("Име : ");
        string name = Console.ReadLine();
        Console.Write("Фамилия : ");
        string familyName = Console.ReadLine();
        Console.Write("Години : ");
        double age = double.Parse(Console.ReadLine());
        Console.Write("Град : ");
        string homeCity = Console.ReadLine();
        Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", name, familyName, age, homeCity);
        //Console.WriteLine("You are " + name + " " + familyName + ", a " + age + "-years old person from " + homeCity + ".");
        //Напишете C# програма, която прочита от конзолата име, фамилия, възраст и 
        //град и печата съобщение от следния вид: “You are <firstName> <lastName>, a <age>-years old person from <town>”.
    }
}