// /home/david/Other projects/marvin_fall_07_08/marvin_cs/Marvin_cs/sensors.cs created with MonoDevelop
// User: david at 11:28 PM 2/11/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;
using System.Collections;
using Phidgets;
using Phidgets.Events;

namespace Marvin_cs
{

	public class Sensor
	{
		static InterfaceKit ifKit;

        public delegate void LogHandler(String message);

        Logger mylog = new Logger("process.log");

        public String Attach = "Not Set";
        public String Detach = "Not Set";
        public String Error = "Not Set";
        public String InputChange = "Not Set";
        public String OutputChange = "Not Set";
        public String SensorChange = "Not Set";

        public Double frontside;
        public Double backside;

        public Boolean frontIR;
        public Boolean frontBump;

        public Double wheelR;
        public Double wheelL;

        // Declare a delegate that takes a single string parameter
        // and has no return type.

        public Sensor()
		{
            
			try
            {
                //Initialize the InterfaceKit object
                ifKit = new InterfaceKit();

                //Hook the basica event handlers
                ifKit.Attach += new AttachEventHandler(ifKit_Attach);
                ifKit.Detach += new DetachEventHandler(ifKit_Detach);
                ifKit.Error += new ErrorEventHandler(ifKit_Error);

                //Hook the phidget spcific event handlers
                ifKit.InputChange += new InputChangeEventHandler(ifKit_InputChange);
                ifKit.OutputChange += new OutputChangeEventHandler(ifKit_OutputChange);
                ifKit.SensorChange += new SensorChangeEventHandler(ifKit_SensorChange);

                //Open the object for device connections
                ifKit.open();

                //Wait for an InterfaceKit phidget to be attached
                Console.WriteLine("Waiting for InterfaceKit to be attached...and the thread to start");
            }
            catch (PhidgetException ex)
            {
                Console.WriteLine(ex.Description);
            }
        }

        public void startSensor()
        {

            // Crate an instance of the delegate, pointing to the logging function.
            // This delegate will then be passed to the Process() function.
            
            //LogHandler myLogger = new LogHandler(log.Log);

            //sensor mySensors = new sensor();

            ifKit.waitForAttachment();

            //Wait for user input so that we can wait and watch for some event data frm the phidget
            Console.WriteLine("Press any key to end... Then press enter");
            Console.Read();

            //User input was rad so we'll terminate the program, so close the object
            ifKit.close();

            //set the object to null to get it out of memory
            ifKit = null;

            //If no expcetions where thrown at this point it is safe to terminate the program
            Console.WriteLine("ok");
            mylog.Close();
        }

        /*void Logger(string s)
        {
            this.txtSensor.Text += s;
            this.txtSensor.Text += "\r\n";
            this.txtSensor.Text += Environment.NewLine;
        }*/

        // The use of the delegate is just like calling a function directly,
        // though we need to add a check to see if the delegate is null
        // (that is, not pointing to a function) before calling the function.
        public void Process(LogHandler logHandler)
        {

            if (logHandler != null)
            {
                logHandler(Convert.ToString(get_frontside()));
                logHandler(get_backside());
            }
        }

        //Attach event handler...Display the serial number of the attached InterfaceKit to the console
        void ifKit_Attach(object sender, AttachEventArgs e)
        {
             set_attach(String.Format("InterfaceKit {0} attached!", e.Device.SerialNumber.ToString()));
            //Console.WriteLine("InterfaceKit {0} attached!", e.Device.SerialNumber.ToString());
        }

        //Detach event handler...Display the serial number of the detached InterfaceKit to the console
        void ifKit_Detach(object sender, DetachEventArgs e)
        {
            //Console.WriteLine("InterfaceKit {0} detached!", e.Device.SerialNumber.ToString());
        }

        //Error event handler...Display the error description to the console
        void ifKit_Error(object sender, ErrorEventArgs e)
        {
            //Console.WriteLine(e.Description);
        }

        //Input Change event handler...Display the input index and the new value to the console 
        void ifKit_InputChange(object sender, InputChangeEventArgs e)
        {
			//sensor_filter(sender, e);
            //string name;
            //Console.WriteLine("Here is input change");
            //name = sensor_name(sender, e);
            //Console.WriteLine("Input index {0} value (1)", e.Index, e.Value.ToString());
            //function that updates 
        }

        //Output change event handler...Display the output index and the new valu to the console
        void ifKit_OutputChange(object sender, OutputChangeEventArgs e)
        {

			//sensor_filter(sender, e);
            //string name = "";
            //Console.WriteLine("Here is output change");
            //set_outputchange(String.Format("Output index {0} value {1}", e.Index, e.Value.ToString()));
            //name = sensor_name(sender, e);
            //Console.WriteLine("Output index {0} value {1}", name, e.Value.ToString());
        }

        //Sensor Change event handler...Display the sensor index and it's new value to the console
        void ifKit_SensorChange(object sender, SensorChangeEventArgs e)
        {

            sensor_filter(sender, e);
            LogHandler myLogger = new LogHandler(mylog.Log);
            Process(myLogger);
			//Console.WriteLine("here");
            //Console.WriteLine("{0} {1}, Value: {2}", e.Index, sensor_filter(sender, e), e.Value);
        }

        // Static Function: To which is used in the Delegate. To call the Process()
        // function, we need to declare a logging function: Logger() that matches
        // the signature of the delegate.
        //static void Logger(string s)
        //{
            //Console.WriteLine(s);
        //}

        static void set_loghandler(string s)
        {

        }

        public void set_attach(string s)
        {
            Attach = s;
        }

        public void set_detach(string s)
        {
            Detach = s;
        }

        public void set_error(string s)
        {
            Error = s;
        }

        public void set_inputchange(string s)
        {
            InputChange = s;
        }

        public void set_outputchange(string s)
        {
            OutputChange = s;
        }

        public string get_outputchange()
        {
            return OutputChange;
        }

        public void set_sensorchange(string s)
        {
            SensorChange = s;
        }

        /// <summary>
        /// Returns the distance of the wall from the front side sensor
        /// </summary>
        /// <returns>double frontside</returns>
        public Double get_frontside()
        {
            return frontside;
        }

        public String get_backside()
        {
            return Convert.ToString(backside);
        }

        public string sensor_filter(object sender, SensorChangeEventArgs e)
        {
            Hashtable names = new Hashtable();
            names.Add("0", "Nothing??");
            names.Add("1", "Front Sensor");
            names.Add("2", "Bump Sensor");
            names.Add("3", "Right Side Wheel Tach");
            names.Add("5", "Nothing??");
            names.Add("4", "Left Side Wheel Tach");
            names.Add("6", "Side Front");
            names.Add("7", "Side Back");

            //Console.WriteLine("test {0}", names["1"]);

            switch (e.Index)
            {
                case (6):
                    frontside = e.Value;
                    break;
                case (7):
                    backside = e.Value;
                    break;
            }

            return names[e.Index.ToString()].ToString();
        }

	}
}