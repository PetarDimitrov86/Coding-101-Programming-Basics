string[] strings = Console.ReadLine().Split(' ');
List<int> nums = strings.Select(int.Parse).ToList();
var sortedNums = nums.OrderBy(x => -x);
var largest3Nums = sortedNums.Take(3);
Console.WriteLine(string.Join(" ", largest3Nums));
