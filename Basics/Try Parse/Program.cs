string num = "123a";
int parseInt;
bool success = Int32.TryParse(num, out parseInt);
Console.WriteLine(success);