for (int j = 0; j < 10;j++)
{
    Console.WriteLine(j++);
}

int i =0;

do
{
    Console.WriteLine(i);
    i++;
} while (i > 10);

int lengthOfText = 0;
do
{
    Console.WriteLine("Please enter the name of a friend");
    string nameOfAFriend = Console.ReadLine();
    lengthOfText += nameOfAFriend.Length;

} while (lengthOfText < 20);
Console.WriteLine("Thanks, that was enough");

int a = 0;
while( a <20)
{
    Console.WriteLine(a);
    a++;
}


for(int c= 0 ; c < 10 ; c++)
{
    
    if(c==5)
    {
        
        continue;
    }
    if(c==7)
    {
        break;
    }
    Console.WriteLine(c);
}