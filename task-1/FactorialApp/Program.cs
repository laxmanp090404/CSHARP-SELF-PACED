class Program
{
    //entry point
    static void Main()
    {

        Console.Write("Enter a positive integer: ");
        //getting input
        string input = Console.ReadLine();

        // Validation
        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        long factorial = CalculateFactorial(number);

        Console.WriteLine($"Factorial of {number} is {factorial}");
    }
    // factorial logic using loops
    static long CalculateFactorial(int n)
    {
        long result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}