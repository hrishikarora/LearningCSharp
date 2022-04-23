int temprature=0;
Console.WriteLine("Enter a temprature");
var temp = Console.ReadLine();
try
{
    temprature = Int32.Parse(temp);
}
catch (FormatException)
{
    
    Console.WriteLine("Enter Correct Temprature");
}

string display = temprature <= 15 ? "it is too cold" : temprature >= 16 && temprature <= 28 ? "It is ok" : "hot";
Console.WriteLine(display);