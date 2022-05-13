using System.Collections.Generic;
List<String> myList = new List<string>() { "hello","this","is","my","list"};

myList.Add("hrishik");
myList.Remove("this");

myList.RemoveAt(0);

foreach (var item in myList)
{
    Console.WriteLine($"{item}");
    
}
var value = myList[1];
Console.WriteLine($"{myList.Count}");
Console.WriteLine($"{value}");
var a = Solution();

foreach (var item in a)
{
    Console.WriteLine($"{item}");
    
}
List<int> Solution()  
{
    List<int> myList = new List<int>();
    for(int i=100;i<=170;i++)
    {
        if(i%2==0)
        myList.Add(i);
    }
    return myList;
}