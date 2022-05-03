string userInput;
System.Console.WriteLine("Write Anything");
userInput=Console.ReadLine();

System.Console.WriteLine("Select the Data type to validate the input you have entered.");
Console.WriteLine($"Press 1 for String\nPress 2 for Integer\nPress 3 for Boolean");
string validData= Console.ReadLine();

switch(validData)
{
    case "1":
        if(IsAllAlphabetic(userInput))
        {
            Console.WriteLine($"Its a string with value {userInput}");
            
        }
        else
        {
            Console.WriteLine($"Its not a proper string ");
            
        }
    
        break;
    case "2":
        if(Int32.TryParse(userInput,out int result1))
        {
            Console.WriteLine($"Its an integer of value {result1}");
            
        }
        else Console.WriteLine($"Not an integer");
        
        break;

    case "3":
        var input=userInput.ToLower();
        if(input=="true"||input=="false")
        {
            Console.WriteLine($"Its a bool {userInput}");
            
        }
        else{
            System.Console.WriteLine("Not a bool");
        }
        break;
}
bool IsAllAlphabetic(string character)
{
    foreach(var c in character)
    {
        if(!char.IsLetter(c))
        {
            return false;
        }
    }
    return true;
}
