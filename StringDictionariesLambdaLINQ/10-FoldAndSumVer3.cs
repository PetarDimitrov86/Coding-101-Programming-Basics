int[] arr = Console.ReadLine()
  .Split(' ').Select(int.Parse).ToArray();
int k = arr.Length / 4;
var row1left = arr.Take(k).Reverse();
var row1right = arr.Reverse().Take(k);
int[] row1 = row1left.Concat(row1right).ToArray();
int[] row2 = arr.Skip(k).Take(2 * k).ToArray();
var sumArr = 
  row1.Select((x, index) => x + row2[index]);
Console.WriteLine(string.Join(" ", sumArr));
