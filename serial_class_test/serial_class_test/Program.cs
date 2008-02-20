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
		static bmove basicmove = new bmove();
			
        static logic marvinbrain = new logic();

        static void Main(string[] args)
        {
            Console.Out.WriteLine("Testing sensors and logic!");
            //Singleton s = new Singleton.Instance();
            ///Singleton single = Singleton.GetInstance();
            
            //SerialComm serialport = SerialComm.GetInstance();
            
            
			marvinbrain.followWall();

            //sensor mySensors = new sensor();
            //sensor.LogHandler myLogger = new sensor.LogHandler(Logger);
            //mySensors.Process(myLogger);

            //Debug.Assert("test" == " test", "this is happening because");
            //Debug.Assert(" Yes" == " Yes");
            //Debug.Assert("test" == " test", "this is happening because", "dave runs haxor leet linux");
        }
        void Logger(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine("\r\n");
            Console.WriteLine(Environment.NewLine);
        }
		
		void Dispose()
		{
			Console.WriteLine("Closing now");
			marvinbrain.close();
		}		
		
    }
}
