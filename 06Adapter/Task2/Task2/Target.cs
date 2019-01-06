using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Target
    {
        int frequency = 100;

        public string PrepareDevice(int frequency)
        {
            this.frequency = frequency * 150;
            return "Wireless Device detected " + this.frequency + " GHz";
        }
        
    }
}
