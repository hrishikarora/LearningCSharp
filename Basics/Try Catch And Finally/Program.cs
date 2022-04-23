Console.WriteLine("Please enter a number");
int userInputAsInt;
var userInput = Console.ReadLine();

if(!string.IsNullOrEmpty(userInput))
{
try
{
     userInputAsInt = Int32.Parse(userInput);

     

     try
     {
         Console.WriteLine($"Divide by 0: {userInputAsInt / 0}");
     }
     catch (DivideByZeroException)
     {
            Console.WriteLine("Cannot divide a number by 0");
    }
}
catch (FormatException)
{
     
        Console.WriteLine("Format exception, please enter correct type next time");
}
catch(OverflowException)
{
        Console.WriteLine("OverFlow Exception, number was too long");
}
catch(ArgumentNullException)
{
        Console.WriteLine("ArgumentNullException, the value was empty");
}
finally
{
        Console.WriteLine("This is called anyways, if error or no error");
}

}
