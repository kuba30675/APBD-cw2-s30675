namespace APBD_cw2_Rental;

public class Headphones(bool isWireless, bool noiseCancelling, string name, string brand, double dp) : Gear(name, brand, dp)
{
    public bool IsWireless { get; } = isWireless;
    public bool HasNoiseCancelling { get; } = noiseCancelling;

}