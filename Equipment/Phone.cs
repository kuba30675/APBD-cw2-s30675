namespace APBD_cw2_Rental;

public class Phone(int bCapacity, double screenSize, bool has5G, string name, string brand, double dp)
    : Gear(name, brand, dp)
{
    public int BatterCapacity { get; } = bCapacity;
    public double ScreenSize { get; } = screenSize;
    public bool Has5G { get; } = has5G;
}