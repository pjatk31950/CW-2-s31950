namespace Task_02;

public class LiquidContainer : Container
{
    public bool IsDangerous { get; }  // zachowaj IsDangerous

    public LiquidContainer(double maxLoad, bool isDangerous, double height, double depth, double tareWeight) 
        : base("L", maxLoad, 0, height, depth, tareWeight)
    {
        IsDangerous = isDangerous;  // przypisanie do IsDangerous
    }
    
    public override void Load(double weight)
    {
        double maxAllowed = IsDangerous ? MaxLoad * 0.5 : MaxLoad * 0.9;  // używaj IsDangerous
        if (CurrentLoad + weight > maxAllowed)
            throw new OverfillException($"Przeładowanie kontenera :  {SerialNumber}!");
        base.Load(weight);
    }
}