﻿using System;
class ThousandDays
{
    static void Main()
    {
        DateTime bitrhday = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
        DateTime answer = bitrhday.AddDays(999);
        Console.WriteLine("{0:dd-MM-yyyy}", answer);
    }
}