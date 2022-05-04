//Declare jagged array
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[5];
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[2];

jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
jaggedArray[1] = new int[] { 1, 2, 3 };
jaggedArray[2] = new int[] { 12, 221 };


//ALternative way
int[][] jaggedArray2 = new int[][]
{
    new int[]{1,2,3},
    new int []{1,2,3}
};

Console.WriteLine($"The value in middle of first entry is {jaggedArray[0][2]}");
for (var i = 0; i < jaggedArray.Length; i++)
{
    for (var j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine($"{jaggedArray[i][j]}");
        
    }
}