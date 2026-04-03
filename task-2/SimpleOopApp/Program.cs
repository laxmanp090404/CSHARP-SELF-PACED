class Person
{
    // Props or Attributes
    public string Name { get; set; }
    public int Age { get; set; }

    // Method or Behaviour
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        // Creating objects
        Person p1 = new Person { Name = "Laxman", Age = 21 };
        Person p2 = new Person { Name = "Ashwin", Age = 25 };
        Person p3 = new Person { Name = "Abu", Age = 22 };

        // Calling method
        p1.Introduce();
        p2.Introduce();
        p3.Introduce();
    }
}