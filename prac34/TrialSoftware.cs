using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    class TrialSoftware : Software
    {
        DateTime InstallationDate { get; set; }
        int FreeTrialPeriod { get; set; }

        public TrialSoftware(string name, string manufacturer, DateTime installationdate, int freetrialperiod):base(name,manufacturer) 
        {
            InstallationDate = installationdate;
            FreeTrialPeriod = freetrialperiod;
        }

        public override void Output()
        {
            Console.WriteLine($"Название: {Name} \nПроизводитель: {Manufacturer}");
            Console.WriteLine($"Дата установки: {InstallationDate.ToShortDateString()}\nСрок бесплатного использования: {FreeTrialPeriod}");
        }
        public override string Date()
        {
            var today = DateTime.Today;
            var expirationDate = InstallationDate.AddDays(FreeTrialPeriod);
            return today <= expirationDate ? "Используется":"Неиспользуется"; 

        }

    }
}
