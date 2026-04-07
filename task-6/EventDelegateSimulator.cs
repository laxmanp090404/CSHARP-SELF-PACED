// defining Delegate
//stores methods that take cnt as @params
public delegate void ThresholdReachedHandler(int count);

// Publisher Class ie the counter which is the consumer
class Counter
{
    public int Count { get; private set; }
    public int Threshold { get; set; }

    // define event
    public event ThresholdReachedHandler OnThresholdReached;

    // method to increment counter
    public void Increment()
    {
        Count++;
        Console.WriteLine($"Current Count: {Count}");

        //raising event when threshold reached
        if (Count == Threshold)
        {
            OnThresholdReached?.Invoke(Count);
        }
    }
}

// subscriber Class ie the handler
class Handlers
{
    public static void ShowMessage(int count)
    {
        Console.WriteLine($"Threshold reached at count {count}");
    }

    public static void LogToConsole(int count)
    {
        Console.WriteLine($"[LOG] Counter hit {count}");
    }

    public static void WarningAlert(int count)
    {
        Console.WriteLine($"Warning: Limit reached ({count})");
    }
}

// Main driver class
class EventDelegateSimulator
{
    static void Main()
    {
        Counter counter = new Counter { Threshold = 5 };

        // subscribe to events when event triggers
        counter.OnThresholdReached += Handlers.ShowMessage;
        counter.OnThresholdReached += Handlers.LogToConsole;
        counter.OnThresholdReached += Handlers.WarningAlert;

        Console.WriteLine("Starting Counter...\n");

        // loop simulation
        for (int i = 0; i < 10; i++)
        {
            counter.Increment();
            //delay
            Thread.Sleep(500);
        }

        Console.WriteLine("\nFinished Execution.");
    }
}