using System.Reflection;
//creating custom attribute
[AttributeUsage(AttributeTargets.Method)]
class RunnableAttribute : Attribute
{
}

// creating classes with methods
class TaskOne
{
    //runnable attribute means it can be executed dynamically
    [Runnable]
    public void SayHello()
    {
        Console.WriteLine("Hello from TaskOne!");
    }

    public void NotRunnable()
    {
        Console.WriteLine("This should NOT run.");
    }
}

class TaskTwo
{
    [Runnable]
    public void SayBye()
    {
        Console.WriteLine("Goodbye from TaskTwo!");
    }

    [Runnable]
    public void AnotherTask()
    {
        Console.WriteLine("Another runnable method in TaskTwo!");
    }
}

// main driver program
class ReflectionCustomAttribute
{
    static void Main()
    {
        Console.WriteLine("Scanning for [Runnable] methods...\n");

        // getting curr assembly or code in the class
        Assembly assembly = Assembly.GetExecutingAssembly();

        //looping through all classes
        foreach (Type type in assembly.GetTypes())
        {
            // looping through all methods
            foreach (MethodInfo method in type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                // checking if method has runnable
                if (method.GetCustomAttributes(typeof(RunnableAttribute), false).Length > 0)
                {
                    Console.WriteLine($"Executing: {type.Name}.{method.Name}");

                    // create instance of class
                    object instance = Activator.CreateInstance(type);

                    // invoking method
                    method.Invoke(instance, null);
                }
            }
        }

        Console.WriteLine("\nExecution Completed.");
    }
}