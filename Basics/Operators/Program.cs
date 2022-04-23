int num1 = 5;
int num2 = 10;
int num3;

//unary operator
num3 = -num1;
Console.WriteLine($"num3 {num3}");

bool isSunny = true;
Console.WriteLine($"Is Sunny? {!isSunny}");

//increment
int num = 0;
num++;
Console.WriteLine($"num is {num}"); 

//postfix increment (1st print then increments)
Console.WriteLine($"num is {num++}"); 
Console.WriteLine($"num is {num}"); 

//prefix increment (1st increment then prints)
Console.WriteLine($"num is {++num}");
Console.WriteLine($"num is {num}"); 

//decrement (same prefix and postfix concept)
num--;
Console.WriteLine($"{num}");


//Arithmetic
Console.WriteLine($"+ is {num1 + num2}");
Console.WriteLine($"- is {num1 - num2}");
Console.WriteLine($"* is {num1 * num2}");
Console.WriteLine($"/ is {num1 / num2}");
Console.WriteLine($"% is {num1 % num2}");


//relational operators
// == != > >= < <= 
bool isLower;
isLower = num1 < num2;


//Logical 
Console.WriteLine($"{isLower} {isSunny}");
if(isLower&&isSunny)
{
    Console.WriteLine("hey");
}

if(!isLower||!isSunny)
{
    Console.WriteLine("Hey  1");
}
else if(!isLower||isSunny)
{
    Console.WriteLine("Hey 2");
}