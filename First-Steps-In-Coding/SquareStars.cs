﻿using System;
class SquareStars
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());      //Вкарва се число от конзолата
        for (int i = 1; i <= n; i++)
            Console.Write("*");
        Console.WriteLine();                      //Горните 3 реда ми правят горната основа на квадрата. Първо оставям само командата Write за да напечата всички звездички на един ред, и чак след тях пускам празен ред с WriteLine
        for (int i = 3; i <= n; i++)              //Тук си представих просто че логиката, по която трябва да направя всички редове на квадрата без първия и последния ред, е да вкарам променлива К, която е с 2 числа пред i или n
        {
            Console.Write("*");                  //вкарвам звездичките в лявата основа
            for (int j = 2; j < n; j++)
                Console.Write(" ");                  //вкарвам интервалите между лявата и дясната основа на квадрата
            Console.Write("*");
            Console.WriteLine();                 //вкарвам и звездичките в дясната основа, и веднга след края вкарвам нов ред с WriteLine
        }
        for (int i = 1; i <= n; i++)
            Console.Write("*");
        Console.WriteLine();                 //и тук аналогично на първите няколко реда, изкарвам долната основа на квадрата. Звездичките пак са с Write само, а накрая отново завършвам с WriteLine
    }
}