using System;
class Program
{
    static void Main(string[] args)
    {
        int PoolCapacity = int.Parse(Console.ReadLine());
        int LitresPerHour1 = int.Parse(Console.ReadLine());
        int LitresPerHour2 = int.Parse(Console.ReadLine());
        decimal hours = decimal.Parse(Console.ReadLine());

        decimal Pipe1Workload = hours * LitresPerHour1;
        decimal Pipe2Workload = hours * LitresPerHour2;
        decimal totalWorklaod = Pipe1Workload + Pipe2Workload;

        int percentagePipe1 = LitresPerHour1 * 100 / (LitresPerHour1 + LitresPerHour2);
        int percentagePipe2 = LitresPerHour2 * 100/ (LitresPerHour1 + LitresPerHour2);
        int percentagePool = (int)totalWorklaod * 100 / PoolCapacity;

        if (PoolCapacity < Pipe1Workload + Pipe2Workload)
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, Math.Abs(Pipe2Workload + Pipe1Workload - PoolCapacity));
        }
        else
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentagePool, percentagePipe1, percentagePipe2);
    }
}
