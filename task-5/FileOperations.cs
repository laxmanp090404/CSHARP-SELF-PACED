class FileProcessor
{
    static void Main()
    {
        // provide path of anime source file
        string inputPath = Path.Combine(Directory.GetCurrentDirectory(), "task-5", "anime.csv");
        // Console.WriteLine("Path is "+inputPath);
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "task-5", "output.txt");

        try
        {
            // check file if exists
            if (!File.Exists(inputPath))
            {
                throw new FileNotFoundException("anime.csv file not found.");
            }

            // read all lines
            string[] lines = File.ReadAllLines(inputPath);

            // total lines (i am not including header)
            int totalLines = lines.Length - 1;

            // reading content as only text no line based demarking
            string content = File.ReadAllText(inputPath);

            // count words
            string[] words = content.Split(
                new char[] { ' ', '\n', ','},
                StringSplitOptions.RemoveEmptyEntries
            );

            //getting number of words
            int wordCount = words.Length;

            // Count anime entries same as numbr of lines
            int animeCount = totalLines;

            // simple operation of filtering high rated anime particularly 8 and above
            var highRated = lines
                .Skip(1)
                .Where(line => line.Contains(",8.") || line.Contains(",9."));

            int highRatedCount = highRated.Count();

            // Prepare result
            string result =
                $"Total Anime: {animeCount}\n" +
                $"Total Lines: {lines.Length}\n" +
                $"Total Words: {wordCount}\n" +
                $"High Rated Anime (8+): {highRatedCount}";

            // Write to output file
            File.WriteAllText(outputPath, result);

            Console.WriteLine("Processing Complete and written to output file");
            Console.WriteLine(result);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found.");
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("File I/0 exception occurred.");
            Console.WriteLine(ex.Message);
        }
        //catching any exception missed from above
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error.");
            Console.WriteLine(ex.Message);
        }
    }
}