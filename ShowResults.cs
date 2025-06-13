namespace CartSpeedCalculator
{
    public class ShowResults
    {
        public void ExportToCsv(UserInput userInput, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Distance (KM),Time (Hours),Speed (KM/H)");

                foreach (var record in userInput.Records)
                {
                    writer.WriteLine($"{record.DistanceKm},{record.TimeHours},{record.SpeedKmPerHour}");
                }
            }

            Console.WriteLine($"CSV file successfully written to: {filePath}");
        }
    }
}
