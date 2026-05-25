using Stripe.Checkout;

namespace DonationsRivera.Services;

public class StripeCheckoutService
{
    public async Task<string> CreateCheckoutSessionAsync(
        decimal amount,
        string currency,
        string donationId,
        string successUrl,
        string cancelUrl)
    {
        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string> { "card" },

            LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmountDecimal = amount * 100,

                        Currency = currency.ToLower(),

                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "Donation",
                            Description = "Thank you for supporting our cause!"
                        }
                    },

                    Quantity = 1
                }
            },

            Mode = "payment",

            SuccessUrl = successUrl,

            CancelUrl = cancelUrl,

            ClientReferenceId = donationId
        };

        var service = new SessionService();

        Session session = await service.CreateAsync(options);

        return session.Url;
    }
}