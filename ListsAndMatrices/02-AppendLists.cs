using System;
using System.Collections.Generic;
using System.Linq;
class AppendLists
{
    static void Main(string[] args)
    {
        List<string> originalList = Console.ReadLine().Split(new char[] { '|' } ).Reverse().ToList();
        List<string> modifiedList = new List<string>();
        for (int i = 0; i < originalList.Count; i++)
        {
            List<string> tempList = originalList[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var item in tempList)
                    modifiedList.Add(item);
        }
       Console.WriteLine(string.Join(" ", modifiedList));
    }
}
