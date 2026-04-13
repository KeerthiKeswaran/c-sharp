using System;
using System.IO;

namespace LogAnalyzer
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputFilePath = "log.txt";
            string outputFilePath = "summary.txt";

            try
            {
                // Verify if file exists (though ReadAllLines also throws exception)
                if (!File.Exists(inputFilePath))
                {
                    throw new FileNotFoundException($"The file '{inputFilePath}' was not found.");
                }

                string[] lines = File.ReadAllLines(inputFilePath);
                int lineCount = lines.Length;
                int totalWordCount = 0;

                foreach (string line in lines)
                {
                    // Split by whitespace and remove empty entries to get accurate word count
                    string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    totalWordCount += words.Length;
                }

                // Prepare the result content
                string result = $"Log Analysis Summary\n" +
                                $"--------------------\n" +
                                $"Processed File: {inputFilePath}\n" +
                                $"Total Lines: {lineCount}\n" +
                                $"Total Words: {totalWordCount}\n" +
                                $"Analysis Date: {DateTime.Now}\n";

                // Output to console
                Console.WriteLine(result);

                // Write the result to a new file
                File.WriteAllText(outputFilePath, result);
                Console.WriteLine($"\nResults successfully written to {outputFilePath}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An I/O error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}