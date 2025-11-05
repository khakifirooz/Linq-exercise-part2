
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.RegularExpressions;

// Aggragation Functions (sum,min,mux,avrage,...)

int[] numbers = { 1, 2, 3, 5, 4, 6, 7, 8, 9 };

string[] names = { "Mehrshad", "Ahmad", "Amir", "Mehdi", "Nima", "Reza", "Mohammad" };

List<Student> Student = new List<Student>()
{
    new Student(){Id = 1001, Name = "Ali", Family = "Abdi" },
    new Student(){Id = 1002, Name = "Emad", Family = "Abdi" },
    new Student(){Id = 1003, Name = "Emad", Family = "Abdi" },
    new Student(){Id = 1004, Name = "Mohsen", Family = "Abdi" },
};

//var result = numbers.Sum();
//Console.WriteLine(result);
//var result = Student.Where(x => x.Id > 1001).Sum(x => x.Id);
//var result = Student.Count(x => x.Name == "Emad");
/*var result = numbers.Aggregate((x,y) => x+y);  */// x = x+y
//var result = names.Aggregate((x,y) => x + ", " + y);
Console.WriteLine(result);









// SET operators( Distinc , Exept , Intersect , Union , Contact )


//List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
//List<int> numbers2 = new List<int>() { 4,5,6,7,8,9 };

//List<string> names1 = new List<string>() { "Ali", "Mohammd", "Nima", "Reza", "Nasrin" };
//List<string> names2 = new List<string>() { "ali", "mohammd", "Nasrin" };

//// var query = numbers1.Except(numbers2); // 1,2,3 in output
//// var query = names1.Except(names2, StringComparer.OrdinalIgnoreCase);  // second argoman is for K sensity
//// var query =  names1.Intersect(names2); // 4,5,6

//var query = names1.Union(names2).Distinct(StringComparer.OrdinalIgnoreCase);
//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}



//List<int> numbers = new List<int> { 1, 2, 2, 2, 2, 5, 4, 5, 8 };

//List<string> names = new List<string> { "Mehrshad", "Ahmad", "Amir", "Mehdi", "Nima", "Reza", "Mohammad" };

//var query = numbers.Distinct();

//var query = names.Distinct(StringComparer.OrdinalIgnoreCase);
//foreach (var item in query)
//{
//    Console.WriteLine(item);  // remove k sensivity cases 
//}

//List<Student> Student = new List<Student>()
//{
//    new Student(){Id = 1001, Name = "Ali", Family = "Abdi" },
//    new Student(){Id = 1001, Name = "Emad", Family = "Abdi" },
//    new Student(){Id = 1001, Name = "Emad", Family = "Abdi" },
//    new Student(){Id = 1001, Name = "Mohsen", Family = "Abdi" },
//};

//var query = Student.Distinct(new CustomCompare());
//foreach (var item in query)
//{
//    Console.WriteLine(item.Name);
//}
//Console.ReadKey();


//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Family { get; set; }
//}

//public class CustomCompare : IEqualityComparer<Student>
//{
//    public bool Equals(Student? x, Student? y)
//    {
//        if(object.ReferenceEquals(x, y)) return true;
//        if(object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null)) return false;
//        return x.Id ==y.Id && x.Name ==y.Name && x.Family ==y.Family;
//    }

//    public int GetHashCode([DisallowNull] Student obj)
//    {
//        if (obj == null) return 0;
//        int IdHashCode = obj.Id.GetHashCode();
//        int NameHashCode = obj.Name.GetHashCode();
//        return IdHashCode + NameHashCode;
//    }
//}


// GroupBy and ToLookup



//List<Student> Students = new()
//{
//    new Student {Id = 101, Name = "Mehrshad", Family ="Khakifirooz", Age = 21},
//    new Student {Id = 102, Name = "Ali", Family ="Ghoreyshi", Age = 25},
//    new Student {Id = 103, Name = "Mehdi", Family ="Ahmadvand", Age = 20},
//    new Student {Id = 104, Name = "Ahmad", Family ="Heidari", Age = 20},
//    new Student {Id = 105, Name = "Amir", Family ="Kochaki", Age = 22},
//    new Student {Id = 106, Name = "Hosein", Family ="khaki", Age = 55},
//    new Student {Id = 107, Name = "Kaml", Family ="Kamalii", Age = 52},
//    new Student {Id = 108, Name = "Amir", Family ="Mohseni", Age = 52},
//};


// chunk example 

//var numbers = new List<int>(Enumerable.Range(10, 53));

//var query = numbers.Chunk(10);
//foreach (var chunk in query)
//{
//    foreach (var item in chunk)
//    {
//        Console.Write(item + " ");
//    }
//    Console.WriteLine();
//}




//var query = Students.GroupBy(x => new { x.Age, x.Name }).OrderBy(x => x.Key.Age);
//foreach (var group in query)
//{
//    Console.WriteLine($"\n Age: {group.Key.Age}, Name: {group.Key.Name}");
//    foreach (var item in group)
//    {
//        Console.WriteLine($"    Id: {item.Id}, Name: {item.Name}, Family: {item.Family}, Age: {item.Age}");
//    }
//}


//var query = Students.GroupBy(x => x.Age);
//foreach (var group in query)
//{
//    Console.WriteLine($"\nkey: {group.Key} count: {group.Count()}");
//    foreach (var item in group)
//    {
//        Console.WriteLine($"    Id: {item.Id}, Name: {item.Name}, Family: {item.Family}, Age: {item.Age}");
//    }
//}

//var query = Students.ToLookup(x => x.Age)
//    .OrderByDescending(k => k.Key)
//    .Select(group => new
//    {
//        Key = group.Key,
//        Items = group.OrderBy(x => x.Family)
//    });

//var student = new Student() {Id = 109, Name = "Mohsen", Family = "Kakifirooz", Age = 52};
//Students.Add(student);    //  because ToLookup is immediet execution

//foreach (var group in query)
//{
//    Console.WriteLine($"\nkey: {group.Key} count: {group.Items.Count()}");
//    foreach (var item in group.Items)
//    {
//        Console.WriteLine($"    Id: {item.Id}, Name: {item.Name}, Family: {item.Family}, Age: {item.Age}");
//    }
//}





//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Family { get; set; }
//    public int Age { get; set; }
//}