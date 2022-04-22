using DataTypes;
int firstNumber=5;
int secondNumber = 10;
string firstName = "Hrishik";
string secondName = "Arora";

Console.WriteLine(firstNumber + secondNumber);
var myObject = new FunctionClass();
Console.WriteLine(myObject.AddingIntegers(firstNumber, secondNumber));
string fullName = myObject.AddingStrings(firstName, secondName);
Console.WriteLine(fullName);
