using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
   public interface IPlane : ITransport
    {  
       public void RaiseChassis();
       public void RemoveChassis();
    }
}
