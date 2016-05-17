using System;
class SquareStarsVer3
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());                      //Взема числото от конзолата
        string stars = new string('*', N);                               //Прави нов стринг с броят звезди на квадрата
        string empty = new string(' ', N - 2);                        //Намира празните пространства в квадрата, като се изважда най-горната и най-долната части на квадрата

        Console.WriteLine(stars);                                     //Тук се изчертава първо най-горната част на квадрата
        for (int i = 0; i < N - 2; i++)                                    //Цикълът изписва празните редове в квадрата
        {
            Console.WriteLine("*" + empty + "*");              //Изписва страните на квадрата с празните пространства
        }
        Console.WriteLine(stars);                                 //Изписва най-долната част на квадрата
    }
}