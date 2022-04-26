using System;
namespace OOPS

{
    public class Human
    {
        // variable first name and full name
        public string firstName = "Random";
        public string lastName = "Guy";

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hi, I am {firstName} {lastName}");
        }

    }
}