namespace Task_02;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; }

    public GasContainer(double maxLoad, double pressure, double height, double depth, double tareWeight) 
        : base("G", maxLoad, 0, height, depth, tareWeight)
    {
        Pressure = pressure;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[ALERT] {message} (Container: {SerialNumber})");
    }

    public override void Unload()
    {
        CurrentLoad *= 0.05;
    }
}