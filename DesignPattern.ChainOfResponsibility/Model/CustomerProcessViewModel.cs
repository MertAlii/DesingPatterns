namespace DesignPattern.ChainOfResponsibility.Model;

public class CustomerProcessViewModel
{
    public int CustomerProcessID { get; set; }
    public string Name { get; set; } = null!;
    public int Amount { get; set; }
    public string EmployeeName { get; set; } = null!;
    public string Description { get; set; } = null!;
}
