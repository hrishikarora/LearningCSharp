//Declaring all variables
string userInputString , firstName , lastName , characterSearch , fullName;

//asking user for a string
Console.Write("Enter a string here: ");

//input the string to userInputString variab;e
userInputString = Console.ReadLine();

//asking user to search for a character
Console.Write("\nWhat character do you want to search?: ");

//user input a character
characterSearch = Console.ReadLine();

//Giving output for 1st occurence of the character
Console.WriteLine(userInputString.IndexOf(characterSearch));

//Asking user for first name
Console.Write("Enter your first name: ");

//input given by user
firstName = Console.ReadLine();

//Asking user for last name
Console.Write("\nEnter your last name: ");

//input given by user
lastName = Console.ReadLine();

//Merging first name and last name
fullName = string.Concat(firstName, " ", lastName);

//Output full name
Console.WriteLine(fullName);


