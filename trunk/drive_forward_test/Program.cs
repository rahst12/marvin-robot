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
            /*bmove basicmove = new bmove();

            basicmove.cruise();
            basicmove.wait(10000);*/
            sensor test = new sensor();
            test.startSensor();
        }
    }
}
