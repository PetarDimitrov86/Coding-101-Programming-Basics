using System;
class TradeComissions
{
    static void Main(string[] args)
    {
        string city = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());
        double comission = -1.0;
        if (0 <= sales && sales <= 500)
        {
            if (city == "sofia") comission = 0.05 * sales;
            if (city == "varna") comission = 0.045 * sales;
            if (city == "plovdiv") comission = 0.055 * sales;
        }
        else if (500 < sales && sales <= 1000)
        {
            if (city == "sofia") comission = 0.07 * sales;
            if (city == "varna") comission = 0.075 * sales;
            if (city == "plovdiv") comission = 0.08 * sales;
        }
        else if (1000 < sales && sales <= 10000)
        {
            if (city == "sofia") comission = 0.08 * sales;
            if (city == "varna") comission = 0.1 * sales;
            if (city == "plovdiv") comission = 0.12 * sales;
        }
        else if (sales > 10000)
        {
            if (city == "sofia") comission = 0.12 * sales;
            if (city == "varna") comission = 0.13 * sales;
            if (city == "plovdiv") comission = 0.145 * sales;
        }
        if (comission == -1)
            Console.WriteLine("error");
        else
            Console.WriteLine("{0:f2}", comission);
    }
}