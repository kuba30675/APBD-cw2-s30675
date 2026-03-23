using APBD_cw2_Rental.Service;

namespace APBD_cw2_Rental.Equipment;

public abstract class Gear
{
    private static int _counter = 0;
    public int Id { get; }
    public string Name { get; }
    public bool IsAvailable { get; set; } = true;
    public string Brand { get; }
    public double DailyPrice { get; set; }

    public Gear(string name, string brand, double dp)
    {
        this.Name = name;
        this.Brand = brand;
        this.Id = _counter++;
        this.DailyPrice = dp;
        Rental.Stash.Add(this);
    }
    
    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(IsAvailable)}: {IsAvailable}, {nameof(Brand)}: {Brand}, {nameof(DailyPrice)}: {DailyPrice}";
    }
}