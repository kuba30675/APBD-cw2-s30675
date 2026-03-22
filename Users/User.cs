namespace APBD_cw2_Rental.Users;

public abstract class User
{
    private static int counter = 0;
    public int Id { get; }
    public string Name { get; }
    public string SecondName { get; }
    public int LeaseLimit { get; }

    public User(string name, string secondName, int leaseLimit)
    {
        Id = counter++;
        Name = name;
        SecondName = secondName;
        LeaseLimit = leaseLimit;
    }
}