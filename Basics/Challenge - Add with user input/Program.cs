
/*
1st Method 
*/
//Initializing variables
int number1, number2;
//Asking user for input and storing in a variable num
Console.Write("Type first number you want to add: ");
string num = Console.ReadLine();

//Converting string to int using parse
number1 = Int32.Parse(num);

//Asking user for input 2 and storing in variable num
Console.Write("Type second number you want to add: ");
num = Console.ReadLine();

//Parsing num from string to int
number2 = Int32.Parse(num);

Console.WriteLine(AdditionFunction(number1, number2));

/*
    2nd Method (min lines of code)
*/
AdditionFunction1();
/// <summary>
/// This function adds two number give by user
/// </summary>
int AdditionFunction(int num1 , int num2)
{
    return num1 + num2;
}
/// <summary>
/// This function adds two number given by user with min lines of code
/// </summary>
void AdditionFunction1()
{
Console.WriteLine("Type two number you want to add: ");
Console.WriteLine(AdditionFunction(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
}