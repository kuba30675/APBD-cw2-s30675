namespace APBD_cw2_Rental;

public class Camera(string sensorType, double megapixels, string brand, string name, double dp) : Gear(name, brand, dp)
{
    public string SensorType { get; }
    public double Megapixels { get; }
}