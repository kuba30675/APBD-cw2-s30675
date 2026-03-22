namespace APBD_cw2_Rental.Equipment;

public class Laptop(int ram, string cpu, string name, string brand, double dp) : Gear(name, brand, dp)
{
    public int RamGB { get; set; } = ram;
    public string CpuModel { get; set; } = cpu;
}