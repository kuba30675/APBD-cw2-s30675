namespace APBD_cw2_Rental.Users;

using APBD_cw2_Rental.Service;

public abstract class User
{
    private static int _counter = 0;
    public int Id { get; }
    public string Name { get; }
    public string SecondName { get; }
    public int LeaseLimit { get; }
    public List<Lease> ActiveLeases { get; }
    public List<Lease> LeaseHistory { get; }

    public User(string name, string secondName, int leaseLimit)
    {
        Id = _counter++;
        Name = name;
        SecondName = secondName;
        LeaseLimit = leaseLimit;
        ActiveLeases = new List<Lease>();
        LeaseHistory = new List<Lease>();
    }

    public void DisplayCurrentLeases()
    {
        Console.Write("Current leases for user " + Name + " " + SecondName + " are:\n" + ActiveLeases);
    }

    public void DisplayPastDeadlineLeases()
    {
        Console.WriteLine("Leases past return deadline for user " + Name + " " + SecondName + ":");
        foreach (var lease in ActiveLeases)
        {
            if (lease.DaysCurrently > lease.LeasedFor)
                Console.WriteLine(lease);
        }
    }
}