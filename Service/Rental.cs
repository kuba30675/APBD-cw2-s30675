namespace APBD_cw2_Rental.Service;
using APBD_cw2_Rental.Equipment;
using APBD_cw2_Rental.Users;

public static class Rental
{
    public static List<Gear> Stash { get; } = new List<Gear>();
    public static List<Lease> AllLeases { get; } = new List<Lease>();

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

    public static void Rent(User user, Gear gear, int days)
    {
        if (user.ActiveLeases.Count >= user.LeaseLimit || !gear.IsAvailable)
        {
            return;
        }

        Lease lease = new Lease(gear, user, DateTime.Now, days, 0);
        AllLeases.Add(lease);
        user.ActiveLeases.Add(lease);
        user.LeaseHistory.Add(lease);
        gear.IsAvailable = false;
    }
}