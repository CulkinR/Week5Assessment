namespace Week5AssessmentTaskSix;

using static System.Console;
public class ElectricBike
{
    public string Id { get; set; }
    public string Location { get; set; }
    public int BatteryPercentage { get; set; }

    public ElectricBike(string id, string location, int batteryPercentage)
    {
        Id = id;
        Location = location;
        BatteryPercentage = batteryPercentage;
    }

    public void PrintDetails()
    {
        WriteLine($"ID: {Id}");
        WriteLine($"Location: {Location}");
        WriteLine($"Battery Percentage: {BatteryPercentage}%");
        WriteLine("========================================");
    }
}