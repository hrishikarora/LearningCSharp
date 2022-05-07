namespace Hashtables
{
    //Summary:
    //      My own custom structure to understand the following :
    //      1> Structures
    //      2> Dictionary Entries
    public struct MyDictionaryEntry
{
        public object key;
        public object value;

        public MyDictionaryEntry(object key, object value)
        {
            this.key = key;
            this.value = value;
        }
    }

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