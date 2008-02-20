using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marvin_cs
{
    public class logic
    {
        bool interupt = false;
        double angle = 0;
        double angleConstant = .01;

        bmove basicmove = new bmove();
        sensor sensors = new sensor();
        
        int response = 50;
        Thread senthr;// new Thread(new ThreadStart(sensors.startSensor));

        public logic()
        {
            senthr = new Thread(new ThreadStart(sensors.startSensor));
            senthr.Start();
        }

        public void followWall()
        {

            while(interupt != true)
            {
                //OLD WHILE ((sensors.frontside - sensors.backside) > -40 && (sensors.frontside - sensors.backside) < 40)
                //WHILE 2 (sensors.frontside > 200 && sensors.frontside < 300 && sensors.backside > 200 && sensors.backside < 300)
                while (System.Math.Abs(sensors.frontside - sensors.backside) < 100)
	            {
                    Console.WriteLine("Normal State | Tolerance: " + (sensors.frontside - sensors.backside) );
                    basicmove.cruise();
		            Thread.Sleep(response);
					if (sensors.frontside < 250)
					{
						Console.WriteLine("Too close | Front Sensor: " + sensors.frontside + "  Back Sensor:" + sensors.backside);
						basicmove.turnright(3);
						basicmove.cruise();
					}
					else if (sensors.frontside > 500)
					{
						Console.WriteLine("Too far | Front Sensor: " + sensors.frontside + "  Back Sensor:" + sensors.backside);
						basicmove.turnleft(3);
						basicmove.cruise();
					}
	            }
                angle = (Math.Abs(sensors.frontside - sensors.backside)) * angleConstant;  //Math.Tan(Math.Abs(sensors.frontside - sensors.backside))/7.8)
	            if (angle > 90) angle = 90;
	            if (sensors.frontside < sensors.backside)
	            {
                    Console.WriteLine("Turning right: " + angle + "° | Front Sensor: " + sensors.frontside + "  Back Sensor:" + sensors.backside);
		            basicmove.turnright(angle);
	            }
	            else
	            {
                    Console.WriteLine("Turning left: " + angle + "° | Front Sensor: " + sensors.frontside + "  Back Sensor:" + sensors.backside);
		            basicmove.turnleft(angle);
	            }
            }
        }
		
		void Dispose()
		{
			Console.WriteLine("Closing now via logic class");
            senthr.Abort();
		}		
		
    }
}
