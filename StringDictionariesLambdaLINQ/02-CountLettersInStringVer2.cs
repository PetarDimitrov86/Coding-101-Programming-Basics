string str = Console.ReadLine().ToLower();
// Count the character occurences
int[] count = new int[str.Max() + 1];
foreach (char ch in str)
    count[ch]++;
// Print the non-zero counts
for (char ch = (char)0; ch < count.Length; ch++)
    if (count[ch] != 0)
        Console.WriteLine($"{ch} -> {count[ch]}");
