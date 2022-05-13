int[] happiness = { 1, 2, 3, 4, 5 };

int[] SunIsShining(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        array[i] += 2;
    }
    return array;
}

SunIsShining(happiness);
foreach (var item in happiness)
{
    Console.WriteLine($"{item}");
    
}