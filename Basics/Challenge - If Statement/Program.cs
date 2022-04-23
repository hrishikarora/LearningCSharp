bool isRegistered = false, isAdmin = false, isLoggedIn = false;
string userName = "", password = "", inputUserName = "", inputUserPassword = "";
if(!isRegistered)
{
    AskingCredentials();
    userName = inputUserName;
    password = inputUserPassword;
    Login();
}
else
{
    Login();
}
void Login()
{
    AskingCredentials();
    if (userName == inputUserName && password == inputUserPassword)
    {
        isLoggedIn = true;
        Console.WriteLine("Sucessfully Logged In");
    }
    else{
        if(userName!=inputUserName)Console.WriteLine("Wrong Username");
        else Console.WriteLine("Wrong Password");
        Console.WriteLine("Try Again");
        Login();
    }

}

void AskingCredentials()
{
    Console.WriteLine("Please type your username ");
    inputUserName = Console.ReadLine();
    Console.WriteLine("Please type your password  ");
    inputUserPassword = Console.ReadLine();

}