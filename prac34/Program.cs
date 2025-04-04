using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    class ЫЫЫЫ
    {
        static void Main(string[] args)
        {
            List<Software> softwareDatabase = new List<Software>
            {
                new FreeSoftware("freesoftware","freeSoftaware Team" ),
                new TrialSoftware("adobe Photoshop","Adobe",DateTime.Parse("2020-05-30"),30),
                new CommercialSoftware("Microsoft Office","Microsoft",1000,DateTime.Parse("2025.01.24"),365),
            };
            Console.WriteLine();
             foreach(var software in softwareDatabase)
            {
                software.Output();
                Console.WriteLine($"На сегоднящний день ПО: {software.Date()}\n");
            }

           
            Console.WriteLine("ПО которое используется на сегодняшний день:");
            foreach (var software in softwareDatabase)
            {
                if (software.Date() == "Используется")
                {
                    software.Output();
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
