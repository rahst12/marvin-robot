using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

namespace Marvin_cs
{

    public class motor
    {
        SerialComm sh = SerialComm.GetInstance();
        byte motorname;
        byte[] realspeed;
        int speed;
        

        public motor(byte motorAB, int set_speed)
        {
            motorname = motorAB;
            speed = set_speed;

            //0 Full Stop (free running)
            //MotorA: 1-31 Reverse with PWM speed control (1 slowest, 31 fastest)
            //32 Full Stop (active braking)
            //MotorB: 33-63 Forward with PWM speed control (33 slowest, 63 fastest)
        }

        public void speed_up()
        {
        	if(speed < 31)
        	{
            	speed++;
            	write();
        //    	Console.WriteLine("Speed up: " + speed + "Motorname: "+motorname+"\n\n");
			}
        }

        public void speed_down()
        {
        	if(speed > -31)
        	{
            	speed--;
            	write();
			}
        }

        public void stop_free()
        {
        	speed = 0;
        	write();
        }

        public void stop_active()
        {
        	speed = 32;
        	write();
        }

        /*public void set_motorname(byte name)
        {
            motorname = name;
        }*/

        public int get_motorname()
        {
            return motorname;
        }
        
        public int get_speed()
        {
        	return speed;
        	
        }

        public void set_speed(int set_speed)
        {
            speed = set_speed;
            write();
        }

        public void write()
        {
            
        	//realspeed = speed; // makes negative speeds positive and plus 32
        	if(speed < 0) realspeed = BitConverter.GetBytes(speed * (-1));
        	else realspeed = BitConverter.GetBytes(speed+32);
            sh.serial_write(motorname, realspeed);
        }

    }
}
