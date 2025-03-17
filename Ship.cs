namespace Task_02;

public class Ship
{
    public string Name { get; }
    public int MaxContainers { get; }
    public double MaxWeight { get; }
    public double MaxSpeed { get; }
    public List<Container> Containers { get; } = new();

    public Ship(string name, int maxContainers, double maxWeight)
    {
        Name = name;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers)
            throw new Exception("Za dużo kontenerów na statku!");
        if (Containers.Sum(c => c.CurrentLoad) + container.CurrentLoad > MaxWeight)
            throw new Exception("Przekroczono maksymalną wagę statku!");
        Containers.Add(container);
    }

    public void UnloadContainer(string serialNumber)
    {
        Containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }

    public void ReplaceContainer(string serialNumber, Container newContainer)
    {
        var index = Containers.FindIndex(c => c.SerialNumber == serialNumber);
        if (index == -1)
            throw new Exception("Nie znaleziono kontenera do zastąpienia!");
        Containers[index] = newContainer;
    }

    public static void TransferContainer(Ship from, Ship to, string serialNumber)
    {
        var container = from.Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container == null)
            throw new Exception("Kontener nie istnieje na tym statku");
        from.Containers.Remove(container);
        to.LoadContainer(container);
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Nazwa Statku : {Name.ToUpper()} \n" +
                          $"Maksymalna liczba kontenerów : {MaxContainers}\n" +
                          $"Maksymalna waga wszystkich kontenerów : {MaxWeight}\n" +
                          $"Maksymalna prędkówść : {MaxSpeed} węzłów \n");
        foreach (var c in Containers)
        {
            Console.WriteLine(c);
        }
    }
}