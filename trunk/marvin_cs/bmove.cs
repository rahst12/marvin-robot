using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Threading;


namespace Marvin_cs
{
    public class bmove
    {
        private motor motorA = new motor(000, 0);
        private motor motorB = new motor(001, 0);
        const int response = 200;    //Delay(in ms) between each command
        const Double friction = 1;          //for turning
        // 1 = apartment carpet

        //Speeds for motor are as folows:
        //-31 full reverse
        //-1 minimal reverse
        //0 stop
        //1 minimal forward
        //31 full forward
        //32 active stopping

        public void forward_speed_up()
        {
            motorA.speed_up();
            motorB.speed_up();
        }

        public void forward_speed_down()
        {
            motorA.speed_down();
            motorB.speed_down();
        }

        public void cruise()
        {
            if (motorA.get_speed() < -15 || motorB.get_speed() < -15)
            {
                motorA.set_speed(-15);
                motorB.set_speed(-15);
                Thread.Sleep(response);
            }
            if (motorA.get_speed() < 0 || motorB.get_speed() < 0)
            {
                motorA.set_speed(0);
                motorB.set_speed(0);
                Thread.Sleep(response);
            }
            if (motorA.get_speed() < 11 || motorB.get_speed() < 11)
            {
                motorA.set_speed(11);
                motorB.set_speed(11);
                Thread.Sleep(response);
            }
            if (motorA.get_speed() < 21 || motorB.get_speed() < 21)
            {
                motorA.set_speed(21);
                motorB.set_speed(21);
                Thread.Sleep(response);
            }
            if (motorA.get_speed() < 31 || motorB.get_speed() < 31)
            {
                motorA.set_speed(31);
                motorB.set_speed(31);
            }
        }

        public void full_speed()
        {
            motorA.set_speed(31);
            motorB.set_speed(31);
        }

        public void retreat()
        {
            if (motorA.get_speed() > 20 || motorB.get_speed() > 20)
            {
                motorA.set_speed(20);
                motorB.set_speed(20);
                Thread.Sleep(response);
            }
            if (motorA.get_speed() > 10 || motorB.get_speed() > 10)
            {
                motorA.set_speed(10);
                motorB.set_speed(10);
                Thread.Sleep(response);
            }
            motorA.set_speed(0);
            motorB.set_speed(0);
            Thread.Sleep(response);
            motorA.set_speed(-11);
            motorB.set_speed(-11);
            Thread.Sleep(response);
            motorA.set_speed(-21);
            motorB.set_speed(-21);
            Thread.Sleep(response);
            motorA.set_speed(-31);
            motorB.set_speed(-31);
            Thread.Sleep(response);
        }

        public void stop()
        {
            if (motorA.get_speed() > 20 || motorB.get_speed() > 20)
            {
                motorA.set_speed(15);
                motorB.set_speed(15);
                Thread.Sleep(response);
            }
            if (motorA.get_speed() < -20 || motorB.get_speed() < -20)
            {
                motorA.set_speed(-15);
                motorB.set_speed(-15);
                Thread.Sleep(response);
            }
            motorA.stop_free();
            motorB.stop_free();
        }

        public void stopnow()
        {
            motorA.stop_active();
            motorB.stop_active();
        }

        public void wait(int mseconds)
        {
            Thread.Sleep(mseconds);
        }

        public void turnleft(double degrees)
        {
            motorB.set_speed(31);
            motorA.set_speed(10);
            Thread.Sleep(Convert.ToInt32(24 * degrees));
        }

        public void turnright(double degrees)
        {
            motorA.set_speed(31);
            motorB.set_speed(10);
            Thread.Sleep(Convert.ToInt32(24 * degrees));
        }

        public void spin()
        {
            motorA.stop_free();
            motorB.stop_free();
            Thread.Sleep(response);
            motorA.set_speed(31);
            motorB.set_speed(-31);
            Thread.Sleep(response);
        }
    }

    // Special class was not transfered.  See original c++ code for this.

}
