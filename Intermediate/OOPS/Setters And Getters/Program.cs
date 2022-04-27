using Setters_And_Getters;
Box firstBox = new Box();

firstBox.Height = 4;
firstBox.Width = 10;
firstBox.SetLength(2);
firstBox.DisplayInfo();

Console.WriteLine($"Volume is {firstBox.Volume}");
Console.WriteLine($"Front surface is {firstBox.FrontSurface}");