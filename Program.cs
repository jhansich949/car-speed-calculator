using CartSpeedCalculator;

internal class Program
{
    static void Main(string[] args)
    {
        var userInput = new UserInput();
        var measure = new Measure();
        var showResults = new ShowResults();

        userInput.SetUserInputs();

        measure.CalculateSpeeds(userInput);

        string outputFilePath = Path.Combine(Environment.CurrentDirectory, "output.csv");
        Console.WriteLine(outputFilePath);
        showResults.ExportToCsv(userInput, outputFilePath);
    }
}