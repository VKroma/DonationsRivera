namespace DonationsRivera.Data;

public class Donation
{
    public int Id { get; set; }

    public string UserId { get; set; } = string.Empty;

    public ApplicationUser? User { get; set; }

    public decimal Amount { get; set; }

    public string Currency { get; set; } = "usd";

    public string Status { get; set; } = "Pending";

    public string? StripeSessionId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}