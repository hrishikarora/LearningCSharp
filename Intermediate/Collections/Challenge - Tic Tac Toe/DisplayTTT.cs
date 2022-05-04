namespace TTT_UserInput
{
    //this class if to display 
    public class DisplayTTT
    {
        public string[,] t { get; set; } =
        {
           {"1","2","3"},
           {"4","5","6"},
           {"7","8","9"},
       };
        /// <summary>
        /// Display TTT
        /// </summary>
        public void Display()
        {
            Console.WriteLine(@"  
    {0}   |    {1}     |  {2}
_______ |__________| ____
        |          |
    {3}   |    {4}     |  {5}
_______ |__________| ____
        |          |
    {6}   |    {7}     |  {8}
_______ |__________| ____
        |          |       
        |          |       
     
",t[0,0],t[0,1],t[0,2],t[1,0],t[1,1],t[1,2],t[2,0],t[2,1],t[2,2]);


        }
    }
}