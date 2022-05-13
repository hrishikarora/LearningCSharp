namespace Hashtables
{


    //Summary:
    //      This is Students class for storing data in HashTables
    public class Students
    {
        public int Id{ get; set; }
        public string Name{ get; set; }

        float gpa;

        public Students(int id, string name,float gpa)
        {
            this.Id = id;
            this.gpa = gpa;
            this.Name = name;
        }
    }
}