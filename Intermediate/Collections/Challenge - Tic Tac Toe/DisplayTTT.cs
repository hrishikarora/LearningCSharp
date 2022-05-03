namespace TTT_UserInput
{
    public class DisplayTTT
    {
        int[] tttArray = new int[] {1,2,3,4,5,6,7,8,9};
        /// <summary>
        /// Display TTT
        /// </summary>
        public void Display()
        {
            Console.WriteLine(@"  
 1   |  2   |   3
____ | ____ | ____
     |      |
 4   |  5   |   6
____ | ____ | ____
     |      |
 7   |  8   |   9
____ | ____ | ____ 
     |      |       
     |      |       
     
");

        }
    }
}