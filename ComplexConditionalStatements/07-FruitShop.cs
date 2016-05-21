using System;
class FruitShop
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine().ToLower();
        string dayOfWeek = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());
        var price = -1.0;   //Задава се стойност -1 за да може ако не се промени тази стойност през някой от if-овете да изкарва грешка
        if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
        {
            if (product == "banana") price = 2.50;
            else if (product == "apple") price = 1.20;
            else if (product == "orange") price = 0.85;
            else if (product == "grapefruit") price = 1.45;
            else if (product == "kiwi") price = 2.70;
            else if (product == "pineapple") price = 5.50;
            else if (product == "grapes") price = 3.85;
        }
        else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
        {
            if (product == "banana") price = 2.70;
            else if (product == "apple") price = 1.25;
            else if (product == "orange") price = 0.90;
            else if (product == "grapefruit") price = 1.60;
            else if (product == "kiwi") price = 3.00;
            else if (product == "pineapple") price = 5.60;
            else if (product == "grapes") price = 4.20;
        }
        if (price >= 0)
            Console.WriteLine("{0:f2}", price * quantity);  //{0:f2} изписва числото ЗАДЪЛЖИТЕЛНО с 2 цифри след десетичната запетая
        else
            Console.WriteLine("error");
    }
}