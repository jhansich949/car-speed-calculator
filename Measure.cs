namespace CartSpeedCalculator
{
    public class Measure
    {
        public void CalculateSpeeds(UserInput userInput)
        {
            foreach (var record in userInput.Records)
            {
                if (record.TimeHours > 0)
                {
                    record.SpeedKmPerHour = Math.Round(record.DistanceKm / record.TimeHours, 2);
                }
                else
                {
                    record.SpeedKmPerHour = 0;
                }
            }
        }
    }
}
