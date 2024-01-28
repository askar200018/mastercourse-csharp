namespace ConsoleUIClass;

public class AddressModel
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    private string _zip;
    public string Zip
    {
        set { _zip = value; }
    }

    public string FullAddress
    {
        get
        {
            return $"{StreetAddress} {City} {State}";
        }
    }
}
