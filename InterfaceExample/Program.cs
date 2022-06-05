using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Supra supra = new Supra();
            supra.TurnOnEngine();
            supra.Move();
            supra.DoBeepSound();
            Console.WriteLine(supra.ToString());

            Fighter fighter = new Fighter();
            fighter.TurnOnEngine();
            fighter.Move();
            fighter.RaiseChassis();
            fighter.RemoveChassis();
            Console.WriteLine(fighter.ToString());

        }
    }
}
