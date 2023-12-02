namespace SMTApp.Models;

internal class RentPaymentDetails
{
    public List<PaymentDetails> AllPayments { get; set; } = new();
    public double? Balance { get; set; }
}
