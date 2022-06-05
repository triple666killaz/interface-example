using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class Supra : ICar
    {
       public void TurnOnEngine()
        {
            Console.WriteLine("smile \nsweet \nsister\nsadistic\nsurprise\nservice\nwe are"+
                "\nSUUUUUUUUUUUUUUUUUUUUUUUPRAAAAAAAAAAAA");
        }

        public void Move()
        {
            Console.WriteLine("Gas, gas, gas\nI'm gonna step on the gas\n"+
                "Tonight, I'll fly (and be your lover)\nYeah, yeah, yeah\nI'll be so quick as a flash\nAnd I'll be your hero ");
        }

        public void DoBeepSound()
        {
            Console.WriteLine("Beep-beep");
        }

        override public string ToString()
        {
            return "yeah it`s supra";
        }


    }
}
