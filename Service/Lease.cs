namespace APBD_cw2_Rental.Service;
using APBD_cw2_Rental.Equipment;
using APBD_cw2_Rental.Users;

public class Lease
{
    private static int _counter = 10;
    public int Id { get; }
    public Gear Gear { get; }
    public User User { get; }
    public DateTime LeaseDate { get; }
    //LeasedFor oznacza liczbe dni na ile wypozyczono sprzet
    public int LeasedFor { get; set; }
    //DaysCurrently to ile aktualnie dni wypozyczenia minelo
    public int DaysCurrently { get; set; }
    public bool IsReturned { get; set; } = false;

    public Lease(Gear gear, User user, DateTime leaseDate, int leasedFor, int daysCurrently)
    {
        Id = _counter;
        _counter += 10;
        Gear = gear;
        User = user;
        LeaseDate = leaseDate;
        LeasedFor = leasedFor;
        DaysCurrently = daysCurrently;
        Rental.AllLeases.Add(this);
    }

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Gear)}: {Gear}, {nameof(User)}: {User}, {nameof(LeaseDate)}: {LeaseDate}, {nameof(LeasedFor)}: {LeasedFor}, {nameof(DaysCurrently)}: {DaysCurrently}, {nameof(IsReturned)}: {IsReturned}";
    }
}