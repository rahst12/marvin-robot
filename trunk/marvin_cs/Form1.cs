using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Marvin_cs
{
    public partial class Form1 : Form
    {
        // Declare a delegate that takes a single string parameter
        // and has no return type.
        //public delegate void LogHandler(string message);
        
        //logic marvinbrain = new logic();
           	
        public Form1()
        {
			
			Console.WriteLine("1");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			//marvinbrain.followWall();
			Console.WriteLine("NBLEFLADSFLASDLS");
            //SerialComm test = new SerialComm();

            // Crate an instance of the delegate, pointing to the logging function.
            // This delegate will then be passed to the Process() function.
//            sensor mySensors = new sensor();
//            sensor.LogHandler myLogger = new sensor.LogHandler(Logger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);
//            mySensors.Process(myLogger);

        }

        private void btTurn_Click(object sender, EventArgs e)
        {

            //basicmove.turnleft();
        }

        private void btForward_Click(object sender, EventArgs e)
        {
            //basicmove.forward_speed_up();
        }

        void Logger(string s)
        {
            this.txtSensor.Text += s ;
            this.txtSensor.Text += "\r\n";
            this.txtSensor.Text += Environment.NewLine;
        }
//		
//		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
//		{
//			Console.WriteLine("Closing now");
//			marvinbrain.close();
//		}
    }
}