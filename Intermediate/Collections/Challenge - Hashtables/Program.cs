using Hashtables;
using System.Collections;
Students[] student = new Students[5];

student[0]  = new Students(1, "ABC", 5.5f);
student[1] = new Students(2, "DEF", 5.5f);
student[2]   = new Students(3, "GHI", 5.5f);
student[3]   = new Students(4, "JKL", 5.5f);
student[4]   = new Students(5, "JKL", 5.5f);

Hashtable studentTable = new Hashtable();

for (int i = 0; i < 5;i++)
{
    if(studentTable.ContainsKey(student[i].Id))
    {
        Console.WriteLine($"Student already exists with same id {student[i].Id}");
        continue;

    }
    studentTable.Add(student[i].Id,student[i]);

}
foreach (Students item in studentTable.Values)
{

    Console.WriteLine($"{item.Name}");
    
}