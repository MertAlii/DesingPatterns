using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Model;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Melahat Alkan";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Melahat Alkan";
                customerProcess.Description = "Para Çekme Tutarı Bölge Direktörünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Gerçekleştirilemedi, Müşterinin Günlük Maksimum Çekebileceği Tutar 400.000₺ olup daha fazlası için birden fazla gün şubeye gelmesi gerekli...";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}