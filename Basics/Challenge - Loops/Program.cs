int  counter = 0, i = 0;
double average = 0;
while(counter!=-1)
{
    
    Console.WriteLine("Please type students marks ");
    string marks = Console.ReadLine();
    int marks1 = 0;
    try{
        marks1 = Int32.Parse(marks);
    }
    catch(Exception)
    {
     
        Console.WriteLine("Please type valid marks ");
        break;
    }
    if(marks1==-1)
    {
        counter = -1;
    }
    else
    {
        average += marks1;
        i++;
    }
  
}
try
{
    Console.WriteLine($"Average is {average / i}");
}
catch(DivideByZeroException)
{
    Console.WriteLine("No marks yet inputted");
}