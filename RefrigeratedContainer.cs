namespace Task_02;

public class CoolingContainer : Container, IHazardNotifier
{
    public CoolingContainer(double maxLoad, double temperature, double height, double depth, double tareWeight) 
        : base("C", maxLoad, temperature, height, depth, tareWeight) {}

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"ALERT {message} , Container : {SerialNumber}");
    }
}