namespace CartSpeedCalculator
{
    public class UserInput
    {
        public List<DataSet> Records { get; set; } = new List<DataSet>();

        public void SetUserInputs()
        {
            Records.Add(new DataSet { DistanceKm = 100, TimeHours = 2 });
            Records.Add(new DataSet { DistanceKm = 200, TimeHours = 2.5 });
            Records.Add(new DataSet { DistanceKm = 10.5, TimeHours = 0.56 });
            Records.Add(new DataSet { DistanceKm = 150, TimeHours = 3 });
            Records.Add(new DataSet { DistanceKm = 180, TimeHours = 2.25 });
            Records.Add(new DataSet { DistanceKm = 75, TimeHours = 1.5 });
            Records.Add(new DataSet { DistanceKm = 50, TimeHours = 1 });
            Records.Add(new DataSet { DistanceKm = 220, TimeHours = 2.75 });
            Records.Add(new DataSet { DistanceKm = 95, TimeHours = 1.8 });
            Records.Add(new DataSet { DistanceKm = 300, TimeHours = 4 });
        }
    }
}
