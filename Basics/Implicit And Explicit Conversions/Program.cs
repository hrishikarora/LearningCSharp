double myDouble = 13.37;
int myInt;
#region  Explicit
//explicit conversion
//cast double to integer
myInt = (int)myDouble;
Console.WriteLine(myInt);
#endregion

#region Implicit
//implicit conversion
int num = 12390532;
long bigNum = num;

float myFloat = 13.37f;
double myDouble1 = myFloat;
#endregion

#region TypeConversion
string myString = myDouble.ToString();
string myString1 = num.ToString();


bool sunIsShining = false;


string sunIsShiningString = sunIsShining.ToString();
Console.WriteLine(sunIsShiningString);
#endregion


#region Parse
string myIntegerString1 = "13";
string myIntegerString2 = "20";
int myInteger = Int32.Parse(myIntegerString1);
int myInteger2 = Int32.Parse(myIntegerString2);
Console.WriteLine(myInteger + myInteger2);
#endregion