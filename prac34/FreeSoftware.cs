using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    class FreeSoftware : Software
    {
        public FreeSoftware(string name, string manufacturer) : base(name, manufacturer) { }

        public override void Output()
        {
            Console.WriteLine($"Название: {Name} \nПроизводитель: {Manufacturer}");
        }

        public override string Date()
        {
            return "Используется";
        }

    }
}
