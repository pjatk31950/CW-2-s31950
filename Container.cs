namespace Task_02;

public class Container
{
    public string SerialNumber { get; }
    public double MaxLoad { get; }
    public double CurrentLoad { get;  set; }
    public double Temp { get; }
    public double Height { get;}
    public double TareWeight { get;}
    public double Depth { get;}
    
    private static int counter = 1;

    protected Container(string type, double maxLoad, double temp, double height,double tareWeight, double depth)
    {
        SerialNumber = $"KON-{type}-{counter++}";
        MaxLoad = maxLoad;
        Temp = temp;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
    }

    public virtual void Load(double weight)
    {
        if (CurrentLoad + weight > MaxLoad)
            throw new OverfillException("Overfill");
        CurrentLoad += weight;
    }

    public virtual void Unload()
    {
        CurrentLoad = 0;
    }

    public override string ToString()
    {
        return $"{SerialNumber} - {GetType().Name}, " +
               $"Load: {CurrentLoad}/{MaxLoad} kg, " +
               $"Temp: {Temp}°C, " +
               $"Height: {Height} cm, " +
               $"Depth: {Depth} cm, " +
               $"TareWeight: {TareWeight} kg";
    }
}