var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
int pos = 0;
while (pos < nums.Count - 1)
  if (nums[pos] == nums[pos + 1])
  {
    nums.RemoveAt(pos);
    nums[pos] = 2 * nums[pos];
    pos--; 
    if (pos < 0) pos = 0;
  }
  else pos++;
Console.WriteLine(string.Join(" ", nums));
