class AsyncSimulator
{
    // Simulated async data source 1
    // Task<DataType> so here return type is string 
    public static async Task<string> FetchDataFromSource1()
    {
        await Task.Delay(2000); // delay like in api call
        return "Data from Source 1 say weather db";
    }

    // Simulated async data source 2
    public static async Task<string> FetchDataFromSource2()
    {
        await Task.Delay(3000);
        return "Data from Source 2 say pollutant data";
    }

    // Simulated async data source 3 (with exception mean no result without exception all task executes)
    public static async Task<string> FetchDataFromSource3()
    {
        await Task.Delay(1500);

        // Simulating failure
        // throw new Exception("Error fetching data from Source 3");
        // if no failure then results printed
        return "Data from Source 3 say xAi usecase";
    }

    // Main method
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting async ops...\n");

        try
        {
            // Starting all tasks
            Task<string> task1 = FetchDataFromSource1();
            Task<string> task2 = FetchDataFromSource2();
            Task<string> task3 = FetchDataFromSource3();

            // wait for all tasks using await
            // only when all tasks complete execution is successful
            string[] results = await Task.WhenAll(task1, task2, task3);
            // only executed when all task occur without exception
            Console.WriteLine("All tasks completed successfully!\n");

            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception occurred: {ex.Message}");
        }

        Console.WriteLine("\nExecution Finished.");
    }
}