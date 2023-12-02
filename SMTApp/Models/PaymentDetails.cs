namespace SMTApp.Models;

internal class PaymentDetails
{
    public string GUID { get; set; } = (new Guid()).ToString();
    public DateTime? PaymentDate { get; set; }= DateTime.Now;
    public double? Amount { get; set; } = 0;
    public string Description { get; set; }
}
