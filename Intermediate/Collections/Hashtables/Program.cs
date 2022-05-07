using Hashtables;
using System.Collections;

Students stud1 = new Students(1, "Hrishik", 9.8f);
Students stud2 = new Students(3, "ABC", 9f);
Students stud3 = new Students(5, "DEF", 8f);
Students stud4 = new Students(2, "GHI", 7.5f);
Students stud5 = new Students(4, "JKL", 6.96f);

//Summary:
//      Storing data in Hashtables
Hashtable table = new Hashtable();

table.Add(stud1.Id,stud1);
table.Add(stud2.Id, stud2);
table.Add(stud3.Id, stud3);
table.Add(stud4.Id, stud4);
table.Add(stud5.Id, stud5);

Students studentData1 = (Students) table[1];

Console.WriteLine($"{studentData1.Id}");

//Summary:
//      This is one way of iterating in Hashtables

// foreach (DictionaryEntry item in table)
// {
//     Students temp = (Students)item.Value;
//     Console.WriteLine($"{temp.Name}");
    

// }

/// summary:
///     Another way of iteration in hashtables

foreach (Students value in table.Values)
{
    Console.WriteLine($"{value.Name}");
    
}


/// summary:
///     This is implementing my own DictionaryEntry Structure 
///     MyDictionaryEntry is defined in Students Class

List<MyDictionaryEntry> myDictionaryEntries = new List<MyDictionaryEntry>();

MyDictionaryEntry abc = new MyDictionaryEntry(10, "Hello");
MyDictionaryEntry def = new MyDictionaryEntry(20, "Hell");
MyDictionaryEntry ghi = new MyDictionaryEntry(30, "Hel");
MyDictionaryEntry jkl = new MyDictionaryEntry(40, "He");
myDictionaryEntries.Add(abc);
myDictionaryEntries.Add(def);
myDictionaryEntries.Add(ghi);
myDictionaryEntries.Add(jkl);

foreach (MyDictionaryEntry item in myDictionaryEntries)
{
    Console.WriteLine($"{item.value}");
    
}