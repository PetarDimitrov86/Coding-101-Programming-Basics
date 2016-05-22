var num = int.Parse(Console.ReadLine());
while (num < 1 || num > 100)
{
   Console.WriteLine("Invalid number!");
   num = int.Parse(Console.ReadLine());
}
Console.WriteLine("The number is: {0}", num);
