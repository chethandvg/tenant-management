namespace SMTApp.Models;;

internal class Tenant
{
    public string GUID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string AadharNumber { get; set; } = string.Empty;
    public string PanNumber { get; set; } = string.Empty;
    public int NumberOfResidents { get; set; } = 0;
    public bool PresentTenant { get; set; } = false;
    public DateTime? StartDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; } = null;
    public List<PaymentDetails> BorrowedMoney { get; set; } = new();
    public List<PaymentDetails> Payments { get; set; } = new();
}
