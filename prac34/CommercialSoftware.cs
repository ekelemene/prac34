using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    class CommercialSoftware : Software
    {

        double Price { get; set; } 
        DateTime InstallationDate { get; set; }
        int TrialPeriod { get; set; }

        public CommercialSoftware(string name, string manufacturer, double price, DateTime installationdate, int trialperiod) : base(name, manufacturer)
        {
            Price = price;
            InstallationDate = installationdate;
            TrialPeriod = trialperiod;
        }
        public override void Output()
        {
            Console.WriteLine($"Название: {Name} \nПроизводитель: {Manufacturer}");
            Console.WriteLine($"Цена: {Price}\nДата установки: {InstallationDate.ToShortDateString()}\nСрок бесплатного использования: {TrialPeriod}");
        }
        public override string Date()
        {
            var today = DateTime.Today;
            var expirationDate = InstallationDate.AddDays(TrialPeriod);
            return today <= expirationDate ? "Используется" : "Неиспользуется";
        }

    }
}
