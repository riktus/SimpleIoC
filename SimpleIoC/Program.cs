using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Container;
using SimpleIoC.Data;

namespace SimpleIoC
{
    class Program
    {
        private static IWorker worker;
        static void Main(string[] args)
        {
            Configurator.ConfigureContainer();

            worker = Core.Resolve<IWorker>();

            worker.Work();
        }
    }
}
