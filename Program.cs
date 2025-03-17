// See https://aka.ms/new-console-template for more information

using Task_02;

class Program
{
    static void Main()
    {
        var ship = new Ship("Dar Pomorza", 10, 1000000);
        
        var meatContainer = new CoolingContainer(10000, 13.3, 300, 300, 500);
        var liquidContainer = new LiquidContainer(20000, true, 400, 400, 1000);
        var gasContainer = new GasContainer(30000, 5.4, 500, 500, 1500);

        try
        {
            meatContainer.Load(4000);
            liquidContainer.Load(8000);
            gasContainer.Load(12000);

            ship.LoadContainer(meatContainer);
            ship.LoadContainer(liquidContainer);
            ship.LoadContainer(gasContainer);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
        
        ship.PrintInfo();
    }
}