using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Container;
using SimpleIoC.Data;

namespace SimpleIoC
{
    public static class Configurator
    {
        public static void ConfigureContainer()
        {
            IoContainer.Bind<IWorker, Worker>();
        }
    }
}
