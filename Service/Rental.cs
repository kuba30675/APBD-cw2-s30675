namespace APBD_cw2_Rental.Service;
using APBD_cw2_Rental.Equipment;

public static class Rental
{
    public static List<Gear> Stash { get; }
    public static List<Lease> AllLeases { get; }

    public static void ShowAllEquipment()
    {
        Console.WriteLine("All the equipment available in the Rental:");
        foreach (var gear in Stash)
        {
            Console.WriteLine(gear);
        }
    }

    public static void ShowAvailableEquipment()
    {
        foreach (var gear in Stash)
        {
            if(gear.IsAvailable)
                Console.WriteLine(gear + " is available to rent");
        }
    }
}