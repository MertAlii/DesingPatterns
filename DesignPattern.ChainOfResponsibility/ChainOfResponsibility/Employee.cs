using DesignPattern.ChainOfResponsibility.Model;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility;

public abstract class Employee
{
    protected Employee NextApprover;
    public void SetNextApprover(Employee superVisor)
    {
        this.NextApprover = superVisor;
    }

    public abstract void ProcessRequest(CustomerProcessViewModel req);
}
