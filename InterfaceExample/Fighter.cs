using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
   public class Fighter : IPlane
    {

        private bool isChassisOn = true;

        public void TurnOnEngine()
        {
                Console.WriteLine("Engine is turned on");   
        }
        
        public void Move()
        {
            Console.WriteLine("F-15 goes brbrbrbrbr");
        }

        public void RaiseChassis()
        {
            this.isChassisOn = true;
        }

        public void RemoveChassis()
        {
            this.isChassisOn = false;
        }

        override public string ToString()
        {
            return "Fighter is ready to fight. Chassis status : " + this.isChassisOn;
        }

    }
}
