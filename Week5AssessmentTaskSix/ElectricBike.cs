namespace Week5AssessmentTaskSix;

using static System.Console;
public class ElectricBike
{
    public string id { get; set; }
    public string location { get; set; }
    public int batteryPercentage { get; set; }

    public ElectricBike(string id, string location, int batteryPercentage)
    {
        this.id = id;
        this.location = location;
        this.batteryPercentage = batteryPercentage;
    }

    void PrintDetails()
    {
        WriteLine($"ID: {id}");
        WriteLine($"Location {location}");
        WriteLine($"Battery Percentage {batteryPercentage}");
    }
}