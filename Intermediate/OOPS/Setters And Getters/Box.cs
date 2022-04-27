namespace Setters_And_Getters
{
    public class Box
    {
        int length;
        int height;
        int width;
        int volume;

        public int FrontSurface{ get { return this.length * this.height;} }



        /// <summary>
        /// Another way for getter and setter
        /// </summary>
        public int Width{ get; set; }




        /// <summary>
        /// This is a setter for setting length (Private property)
        /// </summary>
        /// <param name="length"></param>
        public void SetLength(int length)
        {
            if(length<0) throw new Exception("Length should be higher than 0");
            this.length = length;
        }  


        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }


        /// <summary>
        /// This is a getter for getting a private property
        /// </summary>
        /// <returns></returns>
        /// 
        /// 
        public int GetLength()
        {
            return this.length;
        }


        /// <summary>
        /// setter and getters in one block 
        /// </summary>
        /// <value></value>
         public int Height
         {
             get{
                return height;
            }
            set{
                height = value;
            }
         }


        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length} , height is {height} , width is {Width} and volume is {volume=length*Width*height}");
        }
    }
}