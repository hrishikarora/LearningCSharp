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
            Console.WriteLine($"Hi, I am {firstName} {lastName}\nI have {eyeColor} eyes and I am {age} years old");
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
    }
}