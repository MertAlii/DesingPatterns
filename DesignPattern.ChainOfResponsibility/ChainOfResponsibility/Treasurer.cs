using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Model;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility;

public class Treasurer : Employee
{
    public override void ProcessRequest(CustomerProcessViewModel req)
    {
        Context context = new Context();
        if (req.Amount <= 10000)
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount = req.Amount;
            customerProcess.Name = req.Name;
            customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
            customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
        }
        else
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount = req.Amount;
            customerProcess.Name = req.Name;
            customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
            customerProcess.Description = "Para Çekme İşlemi Onaylanmadı, Müşteriye Talep Ettiği Tutar Ödenemedi, Müdüre Yardımcısına Yönlendirildi";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
            NextApprover.ProcessRequest(req); 
        }
    }
}
