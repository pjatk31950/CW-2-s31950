namespace Task_02;

public class LiquidContainer : Container
{
    public bool IsHazardous { get; }
    
    public LiquidContainer(double maxLoad, bool isHazardous, double height, double depth, double tareWeight) 
        : base("L", maxLoad, 0, height, depth, tareWeight)
    {
        IsHazardous = isHazardous;
    }
    
    public override void Load(double weight)
    {
        double maxAllowed = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (CurrentLoad + weight > maxAllowed)
            throw new OverfillException($"Przeładowanie kontenera :  {SerialNumber}!");
        base.Load(weight);
    }
}