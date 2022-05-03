int[] arrayFirst = new int[5];
arrayFirst[0] = 11;
arrayFirst[1] = 2;
arrayFirst[2] = 3;
arrayFirst[3] = 4;
arrayFirst[4] = 5;

Console.WriteLine("Array first elemet" + " " + arrayFirst[0]);

int[] arraySecond = { 20, 10, 11, 4, 11 };

Console.WriteLine($"ArraySecond first element {arraySecond[0]}");

int[] arrayThird = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine($"ArrayThird first element {arrayThird[0]}");


///
/// For Each loop
///


foreach( var num in arrayFirst)
{
    Console.WriteLine($"{num}");
    
}

string[] myFriends = new string[] { "Hrishik", "me", "Myself" };

foreach(var name in myFriends)
{
    Console.WriteLine($"Hello my friend {name}");
    
}