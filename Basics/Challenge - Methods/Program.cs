string friendName1 = "Ishan" , friendName2 = "Hrishik" , friendName3 = "Friend 3";
GreetFriend(friendName1,friendName2,friendName3);

void GreetFriend(string friendName1 , string friendName2 , string friendName3)
{
    Console.WriteLine($"Hi {friendName1},my friend!");
    Console.WriteLine($"Hi {friendName2},my friend!");
    Console.WriteLine($"Hi {friendName3},my friend!");
}
