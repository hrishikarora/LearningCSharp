using Dictonaries;
//Summary:
//      A way to create dictionary and add values to it
Dictionary<int,string> abc = new Dictionary<int,string>();
abc.Add(1, "hrishik");
abc.Add(2, "hrishik1");
abc.Add(3, "hrishik3");
Console.WriteLine($"{abc[1]}");

foreach (var item in abc)
{
    Console.WriteLine($"{item.Value}");
    
}


//Summary:
//  Adding employee type in dictionary Employee class
Employee[] employees = {
    new Employee("CEO","ABC",95,200),
    new Employee("Manager","DEF",35,25),
    new Employee("HR","GHI",32,21),
    new Employee("Lead Developer","JKL",55,35),


};

Dictionary<string, Employee> ghi = new Dictionary<string, Employee>()
{
    {employees[0].Role,employees[0]},
    {employees[1].Role,employees[1]},
    {employees[2].Role,employees[2]},
    
};

foreach (var item in ghi)
{
    Console.WriteLine($"{item.Key}");

}

Employee result = null;

 