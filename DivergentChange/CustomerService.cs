namespace DivergentChange;

using System.Text.RegularExpressions;

public class CustomerService
{
    private readonly DisplayNameFormatter displayNameFormatter = new DisplayNameFormatter();
    private readonly CustomerEmailValidator emailValidator = new CustomerEmailValidator();


    public bool IsValidEmail(string email)
    {
        return emailValidator.IsValidEmail(email);
    }

    public string FormatDisplayName(string firstName, string lastName)
    {
        return displayNameFormatter.FormatDisplayName(firstName, lastName);
    }

    public int CalculateLoyaltyPoints(int numberOfPurchases)
    {
        return numberOfPurchases * 10;
    }

    public string DetermineAccountStatus(int daysSinceLastLogin)
    {
        if (daysSinceLastLogin > 365)
        {
            return "INACTIVE";
        }
        else if (daysSinceLastLogin > 30)
        {
            return "DORMANT";
        }

        return "ACTIVE";
    }
}