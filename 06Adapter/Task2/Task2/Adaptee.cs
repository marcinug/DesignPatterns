using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Adaptee
    {
        

        

        public string Match(int model)
        {
            string device = "";

            if (model == 1) { 

                device = "DualShock4";
                InstallDrivers(device);
            }
            else if(model == 2)
            {
                device = "XboxOneController";
                InstallDrivers(device);
                
            }
            else if(model == 3)
            {
                device = "Logitech";
                InstallDrivers(device);
                     
            }

            return device;
        }

        private void InstallDrivers(string device)
        {
            Console.WriteLine("Installing drivers for your: " + device);
        }
    }
}
