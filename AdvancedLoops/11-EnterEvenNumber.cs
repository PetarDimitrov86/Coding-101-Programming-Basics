using System;
class Program
{
    static void Main(string[] args)
    {
            while (true)
            {
            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}", n);
                    break;
                }
                else
                    Console.WriteLine("The number is not even");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }             
        }
    }
}
