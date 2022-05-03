//declare 2d array
string[,] matrix;

//declare 3d array
string[,,] threeD;

//two dimension array

int[,] array2D = new int[,]
{
    {1,2,3}, //row 0
    {4,5,6}, //row 1
    {7,8,9}  //row 2
};

Console.WriteLine($"{array2D[2,0]}");

int[,,] array3D = new int[,,]
{
    {
        {0,1,2},
        {3,4,5}
    },
    {
        {6,7,8},
        {9,10,11}
    }
};

Console.WriteLine($"value from 3d array is {array3D[0,0,2]}");

int dimensions = array3D.Rank;
Console.WriteLine($"{dimensions}");
