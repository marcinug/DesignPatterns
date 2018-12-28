using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public abstract class Component
    {
        
        abstract public void AddChild(Component gr);
        abstract public void Traverse();

        abstract public String getName();
    }
}
