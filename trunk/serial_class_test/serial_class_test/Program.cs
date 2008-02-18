using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Diagnostics;
using Marvin_cs;
using System.Threading;
using System.IO;

namespace serial_class_test
{
    class program
    {

        //private static SerialPort comm;
        public delegate void LogHandler(string message);
        bool interupt = false;
        double angle = 0;
        double angleConstant = 1;

        static void Main(string[] args)
        {
            Console.Out.WriteLine("This will test to see if the serial port is functioning.");

            //Singleton s = new Singleton.Instance();
            ///Singleton single = Singleton.GetInstance();
            
//            SerialComm serialport = SerialComm.GetInstance();
//            bmove basicmove = new bmove();
            logic marvinbrain = new logic();
            marvinbrain.followWall();

            //sensor mySensors = new sensor();
            //sensor.LogHandler myLogger = new sensor.LogHandler(Logger);
            //mySensors.Process(myLogger);

            //Debug.Assert("test" == " test", "this is happening because");
            //Debug.Assert(" Yes" == " Yes");
            //Debug.Assert("test" == " test", "this is happening because", "dave runs haxor leet linux");
            Console.Out.WriteLine("I got here... Just as I should.. No Error");

        }
        void Logger(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine("\r\n");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
