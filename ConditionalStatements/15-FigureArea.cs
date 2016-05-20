using System;
class FigureArea
{
    static void Main()
    {
        string figure = Console.ReadLine();
        double area = 1; // ако не му дам стойност, 
                         //не може да го сметне на края
        if (figure == "square")
        {
            double strana = double.Parse(Console.ReadLine());
            area = strana * strana;
        }
        else if (figure == "rectangle")
        {
            double strana1 = double.Parse(Console.ReadLine());
            double strana2 = double.Parse(Console.ReadLine());
            area = strana1 * strana2;
        }
        else if (figure == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            area = radius * Math.PI * radius;
        }
        else if (figure == "triangle")
        {
            double strana = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            area = (visochina * strana) / 2;
        }
        Console.WriteLine(Math.Round(area, 3));
    }
}