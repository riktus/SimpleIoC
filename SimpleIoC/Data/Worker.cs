using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIoC.Data
{
    public class Worker : IWorker
    {
        public void Work()
        {
            Console.Write("Hello from IoC");
            Console.ReadLine();
        }
    }
}
