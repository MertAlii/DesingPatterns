using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Model;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility;

public class Manager : Employee
{
    public override void ProcessRequest(CustomerProcessViewModel req)
    {
        Context context = new Context();
        if (req.Amount <= 250000)
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount = req.Amount;
            customerProcess.Name = req.Name;
            customerProcess.EmployeeName = "Şube Müdürü - Burhan Alkan";
            customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
        }
        else if (NextApprover != null)
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount = req.Amount;
            customerProcess.Name = req.Name;
            customerProcess.EmployeeName = "Şube Müdürü - Burhan Alkan";
            customerProcess.Description = "Para Çekme Tutarı Şube Müdürünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Bölge Müdürüne Yönlendirildi";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
            NextApprover.ProcessRequest(req);
        }
    }
}