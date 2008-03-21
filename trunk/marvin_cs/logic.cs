using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marvin_cs
{
    public class Logic
    {
        bool interupt = false;
        double angle = 0;
        double angleConstant = .01;

        Bmove basicmove = new Bmove();
        Sensor sensors = new Sensor();
        
        int response = 30;
        Thread senthr;// new Thread(new ThreadStart(sensors.startSensor));

        public Logic()
        {
            senthr = new Thread(new ThreadStart(sensors.startSensor));
            senthr.Start();
        }

        ~Logic()
        {
            Console.WriteLine("Closing Now");
            //Thread.Sleep(3000);
            Console.ReadKey();
        }

        public void followWall()
        {
            /*
             * If the bump sensor calls an interupt
             */
            while (interupt != true)
            {
                /*
                 * Are the sensors even within a given tolerance, and make sure interupt isn't true
                 */
                while (System.Math.Abs(sensors.frontside - sensors.backside) < 100 && !interupt)
                {
                    Console.WriteLine("Normal State | Tolerance: " + (sensors.frontside - sensors.backside));
                    basicmove.cruise();
                    Thread.Sleep(response);
                    if (sensors.frontside <= 100) { too_close(); }
                    else if (sensors.frontside >= 600) { too_far(); }
                    //else if (System.Math.Abs(sensors.frontside - sensors.backside) > 30) { align_sensors(); }
                }
                Console.WriteLine("Hey you're sensors are really out of alignment!! Not good.");
            }
        }
        public void align_sensors()
        {
            if (sensors.frontside < sensors.backside)
            {
                angle = 1;
                Console.WriteLine("Turning right: " + angle + "° | Front Sensor: " + sensors.frontside + "  Back Sensor:" + sensors.backside);
                basicmove.turnright(angle);
            }
            else
            {
                angle = 1;
                Console.WriteLine("Turning left: " + angle + "° | Front Sensor: " + sensors.frontside + "  Back Sensor:" + sensors.backside);
                basicmove.turnleft(angle);
            }
        }

        /// <summary>
        /// Determine if marvin is too far away from the wall.
        /// </summary>
        /// <returns></returns>
        public void too_far()
        {
            Console.WriteLine("Too far | Front Sensor: " + sensors.frontside + "  Back Sensor:" + sensors.backside);
            basicmove.turnleft(3);  //create an angle function to fix not turning far enough to the left.
            while (sensors.frontside <= 100 && !interupt)
            {
                basicmove.cruise();
                Thread.Sleep(response);
            }
            basicmove.turnright(3);
        }

        /// <summary>
        /// Determine if marvin is too close to the wall.
        /// </summary>
        public void too_close()
        {
            Console.WriteLine("Too close | Front Sensor: " + sensors.frontside + "  Back Sensor:" + sensors.backside);
            basicmove.turnright(3);  //create an angle function to fix not turning far enough to the right.
            while (sensors.frontside <= 100 && !interupt) 
            {
                basicmove.cruise();
                Thread.Sleep(response);
            }
            basicmove.turnleft(3);
        }

        public double find_angle()
        {
            const double sensors_apart = 8;  //Centimeters
            double front_distance = sensors.get_frontside();
            double x = Math.Tan(sensors_apart / front_distance);  //Convert front distance to 
            
            return Math.Atan(x);
        }
		
		/*void Dispose()
		{
			Console.WriteLine("Closing now via logic class");
            senthr.Abort();
		}*/		
		
    }
}
