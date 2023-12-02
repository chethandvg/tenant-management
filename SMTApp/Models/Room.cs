namespace SMTApp.Models;

internal class Room
{
    public string RoomName { get; set; } = string.Empty;
    public string RoomType { get; set; } = string.Empty;
    public Bill? ElectricityBill { get; set; } = new();
    public Bill? WaterBill { get; set; } = new();
    public double? Balance { get; set; } = 0;
    public Tenant? Tennant { get; set; } = new();
    public double? BorrowedMoney { get; set; }
    public double? LastPaidAmount { get; set; }
    public DateTime? LastPaidDate { get; set; }
    public double? LeaseAmount { get; set; } = 0;
    public double? AdvanceAmount { get; set; } = 0;
    public double? RentAmount { get; set; } = 0;
    public string? TenantGuid { get; set; }
    public string? LastMonthElectricityBill { get; set; }
    public string? ElectricityAccountNumber { get; set; }
    public double? LastMonthElectricityBillAmount { get; set; }
    public string? LastMonthWaterBill { get; set; }
    public string? WaterAccountNumber { get; set; }
    public double? LastMonthWaterBillAmount { get; set; }
    public DateTime? RentStartDate { get; set; }

}
