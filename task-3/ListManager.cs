class ListManager
{
    static void Main()
    {   
        // to store the list of items
        List<string> items = new List<string>();
        
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Display Items");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option: ");

            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    AddItem(items);
                    break;

                case "2":
                    RemoveItem(items);
                    break;

                case "3":
                    DisplayItems(items);
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
    // function to add item
    static void AddItem(List<string> items)
    {
        Console.Write("Enter item to add: ");
        string item = Console.ReadLine().Trim();

        if (!string.IsNullOrEmpty(item))
        {
            // i chose to keep every element in uppercase 
            items.Add(item.ToUpper());
            Console.WriteLine("Item added.");
        }
        else
        {
            Console.WriteLine("You entered nothing.");
        }
    }

    // function to remove item 
    static void RemoveItem(List<string> items)
    {
        Console.Write("Enter item to remove: ");
        // uppercase ensured to remove
        string item = Console.ReadLine().Trim().ToUpper();
        
        // returns true if item is removed
        if (items.Remove(item))
        {
            Console.WriteLine("Item removed.");
        }
        else
        {
            
            Console.WriteLine("Item not found.");
        }
    }

    static void DisplayItems(List<string> items)
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Nothing to display");
            return;
        }

        Console.WriteLine("\nItems:");
        foreach (string item in items)
        {
            Console.WriteLine("-->" + item);
        }
    }
}