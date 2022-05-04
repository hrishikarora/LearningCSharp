 int[,] matrix =
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

for (var i = 0; i < matrix.GetLength(0); i++)
{
    for (var j = 0; j < matrix.GetLength(1); j++)
    {
       // if(matrix[i,j]%2!=0)Console.WriteLine($"{matrix[i,j]}");
        
        
        if(i==j) Console.WriteLine($"{matrix[i,j]}");
        
        
        
    }

    
}
int a = matrix.GetLength(0)-1;
for (var i = 0; i < matrix.GetLength(0); i++)
{
    
    //Console.WriteLine($"{a}");
    
    Console.WriteLine($"{matrix[i,a]}");
    a--;
}

Console.WriteLine($" ");
for (int i = 0,j=2; i < matrix.GetLength(0); i++,j--)
{
    Console.WriteLine($"{matrix[i,j]}");
    
}