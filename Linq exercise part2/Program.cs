// GroupBy and ToLookup

List<Student> Students = new()
{
    new Student {Id = 101, Name = "Mehrshad", Family ="Khakifirooz", Age = 21},
    new Student {Id = 102, Name = "Ali", Family ="Ghoreyshi", Age = 25},
    new Student {Id = 103, Name = "Mehdi", Family ="Ahmadvand", Age = 19},
    new Student {Id = 104, Name = "Ahmad", Family ="Heidari", Age = 20},
    new Student {Id = 105, Name = "Amir", Family ="Kochaki", Age = 22},
    new Student {Id = 106, Name = "Hosein", Family ="khaki", Age = 55},
    new Student {Id = 107, Name = "Kaml", Family ="Kamalii", Age = 52},
    new Student {Id = 108, Name = "Afshin", Family ="Mohseni", Age = 50},
};


var query = Students.GroupBy(x => x.Age);
foreach (var group in query)
{
    Console.WriteLine($"key: {group.Key} count: {group.Count()}");
    foreach (var item in group)
    {
        Console.WriteLine($"Id: {item.Id}, Name: {item.Name}");
    }
}




public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public int Age { get; set; }
}