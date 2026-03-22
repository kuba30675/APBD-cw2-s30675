namespace APBD_cw2_Rental.Equipment;

public class Microphone(string polarPattern, double sens, string name, string brand, double dp) : Gear(name, brand, dp)
{
    public string PolarPattern { get; } = polarPattern;
    public double SensivityDb { get; } = sens;
}