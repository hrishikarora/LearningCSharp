
ParamsMethod("This", "is", "Params", "Method", "Which", "takes", "as", "many", "argument", "as", "you", "want","also","no","Argument","is","also","allowed");
ParamsMethod();
int price = 50;
float pi = 3.14f;
char at = '@';
string book = "The Hobbit";
ParamsMethod2(price,pi,at,book);
ParamsMethod2("Hello", 5.3,'$');

void ParamsMethod(params string[] sentence)
{
    foreach (var item in sentence)
    {
        Console.Write($"{item} ");
        
    }
    Console.WriteLine($"Params MEthod");
    
}
void ParamsMethod2(params object[] stuff)
{
foreach (var obj in stuff)
{
    
        Console.Write($"{obj} ");
        
}
    Console.WriteLine($"\n");
    
}