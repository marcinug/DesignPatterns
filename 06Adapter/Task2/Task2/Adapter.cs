using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Adapter : Adaptee
    {
        public Func<int, string> Request;

        public Adapter(Target target)
        {
            Request = target.PrepareDevice;
        }

        public Adapter(Adaptee adaptee)
        {
            Request = delegate (int model)
            {
                return "The " + Match(model) + " is ready to use.";
            };
        }
        public void ChangeRequest(Func<int, string> ff)
        {
            Request = ff;
        }
    }
}
