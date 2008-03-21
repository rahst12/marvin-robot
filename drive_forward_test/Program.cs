using System;
using System.Collections.Generic;
using System.Text;
using Marvin_cs;

namespace drive_forward_test
{
    class Program
    {
        static void Main(string[] args)
        {
            bmove basicmove = new bmove();

            basicmove.cruise();
            Console.WriteLine("Cruise executed");
            basicmove.wait(10000);
            //logic mbrain = new logic();
            //sensor test = new sensor();
            //test.startSensor();
        }
    }
}
