using TTT_UserInput;



//Initializing variables and objects
DisplayTTT displayTTT = new DisplayTTT();
displayTTT.Display();
int player = 2; //variable for number of player
string userInput="a"; //variable for user input
int counter = 1; //variable for draw or number of total inputs
do
{
    //if previous player was 2nd then current player will be 1
    if(player==2)player = 1;
    else player = 2;
    //asking user for input
    Console.WriteLine($"Player {player}, choose your field");
    userInput=Console.ReadLine();
    //checking if input is valid or not
    if(Int32.TryParse(userInput,out int result)) 
    {
        if (!(result <= 9 && result > 0))
        {
            Console.WriteLine($"Please type number between 0 and 9");
            continue;
        }


    }
    else
    {
        Console.WriteLine($"Please type valid number");
        continue;
    }
    //condidtion on which player used which field for eg pllayer 1 choose 7 for X
    switch(player)
    {
        case 1:
            switch(result)
            {
                case 1:
                    displayTTT.t[0, 0] = "X";
                    break;
                case 2:
                    displayTTT.t[0, 1] = "X";
                    break;
                case 3:
                    displayTTT.t[0, 2] = "X";
                    break;
                case 4:
                    displayTTT.t[1, 0] = "X";
                    break;
                case 5:
                    displayTTT.t[1, 1] = "X";
                    break;
                case 6:
                    displayTTT.t[1, 2] = "X";
                    break;
                case 7:
                    displayTTT.t[2, 0] = "X";
                    break;
                case 8:
                    displayTTT.t[2, 1] = "X";
                    break;
                case 9:
                    displayTTT.t[2, 2] = "X";
                    break;             
            }
            break;
        case 2:
            switch(result)
            {
                case 1:
                    displayTTT.t[0, 0] = "O";
                    break;
                case 2:
                    displayTTT.t[0, 1] = "O";
                    break;
                case 3:
                    displayTTT.t[0, 2] = "O";
                    break;
                case 4:
                    displayTTT.t[1, 0] = "O";
                    break;
                case 5:
                    displayTTT.t[1, 1] = "O";
                    break;
                case 6:
                    displayTTT.t[1, 2] = "O";
                    break;
                case 7:
                    displayTTT.t[2, 0] = "O";
                    break;
                case 8:
                    displayTTT.t[2, 1] = "O";
                    break;
                case 9:
                    displayTTT.t[2, 2] = "O";
                    break;             
            }
            break;
    }
    //checking if game is finished or draw
    counter++;
    if( IsFinish())
    {
        break;
    }
    if(counter==10)
    {
        Console.WriteLine($"Its a draw");
        break;

    }
    displayTTT.Display();
} while (true);

/// <summary>
/// To check if someone has won
/// </summary>
/// <returns></returns>
#region WinGame
 bool IsFinish()
        {
            string[] playerChars = { "X", "O" };
            foreach (var playerChar in playerChars)
            {
                if(((displayTTT.t[0,0] == playerChar) && (displayTTT.t[0,1]==playerChar)&&(displayTTT.t[0,2]==playerChar))
                    || ((displayTTT.t[1,0] == playerChar) && (displayTTT.t[1,1]==playerChar)&&(displayTTT.t[1,2]==playerChar))
                    || ((displayTTT.t[2,0] == playerChar) && (displayTTT.t[2,1]==playerChar)&&(displayTTT.t[2,2]==playerChar))
                    || ((displayTTT.t[0,0] == playerChar) && (displayTTT.t[1,0]==playerChar)&&(displayTTT.t[2,0]==playerChar))
                    || ((displayTTT.t[0,1] == playerChar) && (displayTTT.t[1,1]==playerChar)&&(displayTTT.t[2,1]==playerChar))
                    || ((displayTTT.t[0,2] == playerChar) && (displayTTT.t[1,2]==playerChar)&&(displayTTT.t[2,2]==playerChar))
                    || ((displayTTT.t[0,0] == playerChar) && (displayTTT.t[1,1]==playerChar)&&(displayTTT.t[2,2]==playerChar))
                    || ((displayTTT.t[0,2] == playerChar) && (displayTTT.t[1,1]==playerChar)&&(displayTTT.t[2,0]==playerChar))
                )
                {
                    if (playerChar == "X")
                    {
                        Console.WriteLine($"Player 1 has won");
                    }
                    else{
                        Console.WriteLine($"Player 2 has won");
                    }
                    return true;
                }
            }   
            return false;

        }
        #endregion