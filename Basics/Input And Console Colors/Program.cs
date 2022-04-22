Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Cyan;

string readInput = Console.ReadLine();
int readCharacterAsASCII = Console.Read();
var readKey = Console.ReadKey();
Console.WriteLine("readInput = " + readInput + "\n" + "readCharacterAsASCII = " + readCharacterAsASCII + "\n" + "readKey = " + readKey.Key);