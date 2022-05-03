namespace TTT_UserInput
{
    public class UserInput
    {
        DisplayTTT display = new DisplayTTT();
        int player = 1;
        /// <summary>
        /// This function takes input from the user for tic tac toe
        /// </summary>
        
        public void TakeUserInput()
        {   
            
            Console.WriteLine($"Player {player}: Choose your field");
            
            string userInput = Console.ReadLine();
            
            if(Int32.TryParse(userInput,out int result))
            {
                if(result <= 9 && result > 0) Console.WriteLine($"output is {result}");
                else Console.WriteLine($"Please type between 0 and 9");
                if(player == 1) player = 2;
                else player = 1;
                Console.Clear();
                display.Display();
                TakeUserInput();
                
            }
            else
            {
                Console.WriteLine($"Please type only a digit");
                TakeUserInput();
            }

           

           
          
        }
    }
}