string text = Console.ReadLine().ToLower();
string word = Console.ReadLine().ToLower();
int count = 0, offset = -1;
while (true)
{
   offset = text.IndexOf(word, offset + 1);
   if (offset == -1) break; // No more occurrences
      count++;
}
Console.WriteLine($"Occurrencies: {count}");
