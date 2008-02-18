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
        double angleConstant = .2;
        sensor sensors = new sensor();
        bmove basicmove = new bmove();
        int response = 100;
        

        public logic()
        {
            
        }

        public void followWall()
        {
            while(interupt != true)
            {
                while ((sensors.frontside - sensors.backside) > -20 && (sensors.frontside - sensors.backside) < 20)
	            {
                    basicmove.cruise();
		            Thread.Sleep(response);
	            }
                angle = (Math.Abs(sensors.frontside - sensors.backside)) * angleConstant;  //Math.Tan(Math.Abs(sensors.frontside - sensors.backside))/7.8)
	            if (angle > 90) angle = 90;
	            if (sensors.frontside < sensors.backside)
	            {
		            basicmove.turnright(angle);
	            }
	            else
	            {
		            basicmove.turnright(angle);
	            }
            }
        }


    }
}
