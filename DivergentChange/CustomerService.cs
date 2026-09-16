namespace DivergentChange;

using System.Text.RegularExpressions;

public class CustomerService
{
    private readonly DisplayNameFormatter displayNameFormatter = new DisplayNameFormatter();
    private readonly CustomerEmailValidator emailValidator = new CustomerEmailValidator();
    private readonly LoyaltyPointsCalculator loyaltyPointsCalculator = new LoyaltyPointsCalculator();
    private readonly AccountStatusService accountStatusService = new AccountStatusService();


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
        return loyaltyPointsCalculator.CalculateLoyaltyPoints(numberOfPurchases);
    }

    public string DetermineAccountStatus(int daysSinceLastLogin)
    {
        return accountStatusService.DetermineAccountStatus(daysSinceLastLogin);
    }
}