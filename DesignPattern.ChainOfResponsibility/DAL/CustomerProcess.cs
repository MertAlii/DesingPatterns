namespace DesignPattern.ChainOfResponsibility.DAL;

public class CustomerProcess
{
    public int CustomerProcessID { get; set; }
    public string Name { get; set; } = null!;
    public string Amount { get; set; } = null!;
    public string EmployeeName { get; set; } = null!;
    public string Description { get; set; } = null!;
}
