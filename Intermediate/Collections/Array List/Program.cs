using System.Collections;
//Declaring with undefined amount of object
ArrayList myArrayList = new ArrayList();
//Declaring with defined amount of object
ArrayList myArrayList2 = new ArrayList(100);

myArrayList.Add("hello");
myArrayList.Add(20);
myArrayList.Add(13.37);
myArrayList.Add("BYe");
myArrayList.Add("NO ");
//Delete a specific element
myArrayList.Remove("BYe");
//Delete a element at a index
myArrayList.RemoveAt(0);
//Count in a list
Console.WriteLine($"{myArrayList.Count}");

double sum = 0;
foreach (object obj in myArrayList)
{
    if(obj is int)
    {
        sum += Convert.ToDouble(obj);
    }
    else if(obj is double)
    {
        sum += (double)obj;
    }
    else
    {
        Console.WriteLine($"{obj}");
        
    }
}
Console.WriteLine($"{sum}");
