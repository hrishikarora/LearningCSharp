using System.Diagnostics;

namespace Members_and_Destructors_Finalizers
{
    public class Members
    {
        //Variables (member private)
        private string memberName;
        private string jobTitle;
        private int salary=20000;
        //member- public field
        public int age;
        

        //member - property - exposes jobTitle safely - "Properties start with a capital member"

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //public member method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else{
                Console.WriteLine($"Hi, my name is {memberName} and my job title is {jobTitle}. I am {age} years old");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }
        


        // Constructor member
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object Created");
        }

        //member - finalizer -Destructor
        ~Members()
        {
            //clean up statements

            Console.WriteLine("Deconstruction of Members objects");
            Debug.WriteLine("Deconstruction of Members objects");
        }

    }
}