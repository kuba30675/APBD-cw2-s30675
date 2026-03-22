namespace APBD_cw2_Rental.Equipment;

public abstract class Gear
{
    private static int counter = 0;
    public int Id { get; }
    public string Name { get; }
    public bool IsAvailable { get; set; } = true;
    public string Brand { get; }
    public double DailyPrice { get; set; }

    public Gear(string name, string brand, double dp)
    {
        this.Name = name;
        this.Brand = brand;
        this.Id = counter++;
        this.DailyPrice = dp;
    }
}