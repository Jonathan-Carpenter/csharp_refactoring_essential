namespace DivergentChange;

public class DisplayNameFormatter
{
    public string FormatDisplayName(string firstName, string lastName)
    {
        return firstName.Trim() + " " + lastName.Trim().ToUpper();
    }
}