using System;
class SumSeconds
{
    static void Main()
    {
        int vreme1 = int.Parse(Console.ReadLine());
        int vreme2 = int.Parse(Console.ReadLine());
        int vreme3 = int.Parse(Console.ReadLine());
        int minuti;
        int sekundi;
        int sumarnoVreme = vreme1 + vreme2 + vreme3;
        if (sumarnoVreme >= 60)
        {
            minuti = sumarnoVreme / 60;
            sekundi = sumarnoVreme % 60;
            if (sekundi >= 10)
                Console.WriteLine("{0}:{1}", minuti, sekundi);
            else
                Console.WriteLine("{0}:0{1}", minuti, sekundi);
        }
        else if (sumarnoVreme >= 10)
        {
            Console.WriteLine("0:" + sumarnoVreme);
        }
        else
        {
            Console.WriteLine("0:0" + sumarnoVreme);
        }
    }
}