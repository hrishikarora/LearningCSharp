
bool isAdmin = false, isRegistered = true;
string userName = "";
Console.WriteLine("Please Enter your username");
userName = Console.ReadLine();
if(isRegistered)
{
    Console.WriteLine("Hi there, registered user");
    if(userName != "")
    {
        Console.WriteLine($"Hi there, {userName}");
        if(userName.Equals("admin"))
        {
            Console.WriteLine("Hi there, admin");
        }
    }
}