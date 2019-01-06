using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Client
    {
        static void Main(string[] args)
        {
            Adapter adapter1 = new Adapter(new Adaptee());
            Console.WriteLine("1 " + adapter1.Request(1));

            Adapter adapter2 = new Adapter(new Target());
            Console.WriteLine("2 " + adapter2.Request(2));

            Adapter adapter3 = new Adapter(new Adaptee());
            
            Console.WriteLine("5 " + adapter3.Request(3));

            adapter3.ChangeRequest(delegate (int model)
            {
                return string.Format($"Frequency has changed to {model * 250} GHz.");
            });

            Console.WriteLine("3 " + adapter3.Request(3));

            //Adapter adapter4 = new Adapter(new Target());
            //Console.WriteLine("4 " + adapter4.Request(4));

            Console.ReadKey();
        }
    }
}
