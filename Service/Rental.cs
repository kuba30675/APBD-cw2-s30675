namespace APBD_cw2_Rental.Service;
using APBD_cw2_Rental.Equipment;
using APBD_cw2_Rental.Users;

public static class Rental
{
    public static List<Gear> Stash { get; } = new List<Gear>();
    public static List<Lease> AllLeases { get; } = new List<Lease>();

    public static void ShowAllEquipment()
    {
        Console.WriteLine("All the equipment there is in the Rental:");
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
            Console.WriteLine("Cannot rent that item! Check the lease limit or availability of the item...");
            return;
        }

        Lease lease = new Lease(gear, user, DateTime.Now, days, 0);
        AllLeases.Add(lease);
        user.ActiveLeases.Add(lease);
        user.LeaseHistory.Add(lease);
        gear.IsAvailable = false;
    }
    //metoda Return zwraca ile uzytkownik ma do zaplaty po oddaniu
    public static double Return(Lease lease)
    {
        lease.User.ActiveLeases.Remove(lease);
        lease.Gear.IsAvailable = true;
        lease.IsReturned = true;
        if (lease.DaysCurrently > lease.LeasedFor)
        {
            //jesli termin zwrotu sie przedluzyl to kazdy dzien zwloki kosztuje dodatkowe 20% do ceny dziennej
            return lease.LeasedFor * lease.Gear.DailyPrice +
                   (lease.DaysCurrently - lease.LeasedFor) * lease.Gear.DailyPrice * 1.2;
        }
        else
            return lease.DaysCurrently * lease.Gear.DailyPrice;
        
    }

    public static void Report()
    {
        ShowAllEquipment();
        ShowAvailableEquipment();
        Console.WriteLine("All the leases in the rental up to this point:");
        foreach(var l in AllLeases)
            Console.WriteLine(l);
    }
}