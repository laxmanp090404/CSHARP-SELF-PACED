// student entity with props
class Student
{
    public string Name{get;set;}
    public int Grade {get;set;}
    public int Age{get;set;}
}
// main driver class that perform ops
class StudentManager
{
    public static void Main()
    {   

        List<Student> students = new List<Student>();
        // Populating students
        students.Add(new Student{Name="Laxman",Grade=85,Age=21});
        students.Add(new Student{Name="Ravi",Grade=72,Age=22});
        students.Add(new Student { Name="Anu",Grade=90, Age=20 });
        students.Add(new Student { Name="Keerthick",Grade=65, Age=22 });
        students.Add(new Student { Name="Kishor",Grade=65, Age=23 });

        // Getting threshold from user
        Console.Write("Enter minimum grade: ");
        int threshold = int.Parse(Console.ReadLine());

        // filtering and sorting using LINQ language integrated query
        List<Student> filteredStudents = students.Where(s =>s.Grade > threshold).OrderBy(s=>s.Name).ToList();
        Console.WriteLine("\nFiltered Students:");
        foreach(Student s in filteredStudents)
        {
           Console.WriteLine($"{s.Name} - Grade: {s.Grade}, Age: {s.Age}");
        }
    }
}