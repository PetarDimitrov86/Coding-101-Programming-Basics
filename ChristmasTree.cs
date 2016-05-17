using System;
class ChristmasTree
{
    static void Main()
    {
        int n = 1 + int.Parse(Console.ReadLine());          //добавя се +1, защото за N = 2 трябва да се изкарат 3 реда вместо 2
        for (int i = 1; i <= n; i++)                        //цикъл за строене на дървото
        {

            var spaces = n - i;                             //интервалите преди основата на дървото
            for (int j = 0; j < spaces; j++)
                Console.Write(" ");

            var astrix = i - 1;                             //изкарва звездичките преди стълба на дървото
            for (int j = 0; j < astrix; j++)
                Console.Write("*");

            Console.Write(" | ");                           //стълба на дървото, вкарано в основния цикъл, защото всичко е в един и същ вид на нов ред

            for (int j = 0; j < astrix; j++)                // звездичките веднага след стълба
                Console.Write("*");

            for (int j = 0; j < spaces; j++)                //интервалите след стълба
                Console.Write(" ");
            Console.WriteLine();                            //праща цикъла на нов ред
        }
    }
}