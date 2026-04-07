// Common Interface for all entities
interface IEntity
{
    int Id { get; set; }
}

// sample Entity
//implementing interface ensure id requirement
class Student : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

// generic repo interface
// here the generic type T is ensured to extend IEntity
interface IRepository<T> where T : IEntity
{
    // declare methods to be needed by class implementing this interface
    void Add(T item);
    List<T> GetAll();
    T GetById(int id);
    void Update(T item);
    void Delete(int id);
}

// generic repo implementation
class Repository<T> : IRepository<T> where T : IEntity
{
    // in memory data structure
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        //LINQ here
        return items.FirstOrDefault(x => x.Id == id);
    }

    public void Update(T item)
    {
        var existing = GetById(item.Id);
        if (existing != null)
        {
            int index = items.IndexOf(existing);
            items[index] = item;
        }
    }

    public void Delete(int id)
    {
        var item = GetById(id);
        if (item != null)
        {
            items.Remove(item);
        }
    }
}

// Main driver program
class GenericExample
{
    static void Main()
    {
        IRepository<Student> repo = new Repository<Student>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Student Menu ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All");
            Console.WriteLine("3. Get By Id");
            Console.WriteLine("4. Update");
            Console.WriteLine("5. Delete");
            Console.WriteLine("6. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent(repo);
                    break;
                case "2":
                    DisplayStudents(repo);
                    break;
                case "3":
                    GetStudent(repo);
                    break;
                case "4":
                    UpdateStudent(repo);
                    break;
                case "5":
                    DeleteStudent(repo);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void AddStudent(IRepository<Student> repo)
    {
        Console.Write("Enter Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        repo.Add(new Student { Id = id, Name = name, Age = age });
        Console.WriteLine("Student added.");
    }

    static void DisplayStudents(IRepository<Student> repo)
    {
        var students = repo.GetAll();

        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        foreach (var s in students)
        {
            Console.WriteLine($"{s.Id} - {s.Name}, Age: {s.Age}");
        }
    }

    static void GetStudent(IRepository<Student> repo)
    {
        Console.Write("Enter Id: ");
        int id = int.Parse(Console.ReadLine());

        var student = repo.GetById(id);

        if (student != null)
            Console.WriteLine($"{student.Id} - {student.Name}, Age: {student.Age}");
        else
            Console.WriteLine("Student not found.");
    }

    static void UpdateStudent(IRepository<Student> repo)
    {
        Console.Write("Enter Id to update: ");
        int id = int.Parse(Console.ReadLine());

        var existing = repo.GetById(id);
        if (existing == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.Write("Enter new Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter new Age: ");
        int age = int.Parse(Console.ReadLine());

        repo.Update(new Student { Id = id, Name = name, Age = age });
        Console.WriteLine("Student updated.");
    }

    static void DeleteStudent(IRepository<Student> repo)
    {
        Console.Write("Enter Id to delete: ");
        int id = int.Parse(Console.ReadLine());

        repo.Delete(id);
        Console.WriteLine("Student deleted (if existed).");
    }
}