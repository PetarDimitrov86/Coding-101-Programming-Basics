string text = Console.ReadLine();
string[] words = Console.ReadLine().Split(' ');
foreach (var w in words)
   text = text.Replace(w,
      new string('*', w.Length));
Console.WriteLine(text);
