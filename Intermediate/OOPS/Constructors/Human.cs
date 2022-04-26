namespace Constructors
{
    public class Human
    {
        string firstName;
        string lastName;
        string eyeColor;
        int age;
        /// <summary>
        /// Introducing the object
        /// </summary>
        public void IntroduceYourself()
        {
            if(firstName==null&&lastName==null&&age==0&&eyeColor==null)
                Console.WriteLine($"Hi, I don't have any name yet");
            else if(age==0&&eyeColor==null)
                Console.WriteLine($"Hi I am {firstName} {lastName}");
            else
                Console.WriteLine($"Hi. I am {firstName} {lastName}. I am {age} years old with {eyeColor} eyes!");
        }
        /// <summary>
        /// Constructor with name as argument
        /// </summary>
        /// <param name="myFirstName"></param>
        /// <param name="lastName"></param>
        public Human(string firstName, string lastName,string eyeColor,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        public Human()
        {
            Console.WriteLine("This is default constructor");
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}