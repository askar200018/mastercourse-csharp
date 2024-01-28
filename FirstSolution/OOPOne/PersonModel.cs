namespace OOPOne;

public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public bool HasGreeted { get; set; }
    public AddressModel HomeAddress { get; set; }
}
