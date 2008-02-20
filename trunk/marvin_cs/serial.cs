using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

namespace Marvin_cs
{
    public class SerialComm
    {
        private static SerialComm instance;
        private static SerialPort comm;

        private SerialComm()
        {
            //Linux and Windows OS is checked in the windows_or_unix_port() function
            //LINUX:  /dev/ttyUSB0
            //WINDOWS: COM5
            bool fsuccess;

            try
            {
                comm = new SerialPort(windows_or_unix_port(), 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
                comm.Handshake = System.IO.Ports.Handshake.None;
                if (comm.IsOpen == true)  //true didn't work, so we're trying the number 1
                    comm.Close();
                comm.Open();
                //comm.Close();
                fsuccess = comm.IsOpen;
                if (!fsuccess)
                    Console.WriteLine("Com1 failed to open");
                else
                {
                    Console.WriteLine("/dev/ttyUSB0 opened successfully");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR the port couldn't open.  Is it at the right port?  Details:");
                Console.WriteLine(ex.ToString());
            }

        }

        // This function allows serial to act as a singleton.  The singleton design pattern makes sure that only one instance
        // of serial is ever running.  This is needed because we have two motor instances.  Each time a motor object is
        // inialized it creates a new serial object.  The singleton creates a serial class inside itself and if it is already
        // created it passes back the current instance.  Windows and Fedora has added security measures which locks the com port
        // with the first instance which connects.  Debian based systems don't care how many instances of what is connected
        //  to the com port and lets everything write to it.
        public static SerialComm GetInstance()
        {
            lock (typeof(SerialComm))
            {
                if (instance == null)
                {
                    instance = new SerialComm();
                }
                return instance;
            }
        }

        // writes the information to the serial port.
        public void serial_write(byte motor, byte[] speed)
        {
            //bytes write in ascii
            byte[] bytCount = new byte[3];
            bytCount[0] = 255;
            bytCount[1] = motor;
            bytCount[2] = speed[0];
            comm.Write(bytCount, 0, 3);
        }

        //Determine whether you are on a windows or unix box
        //Returns either COM5 or ttyUSB0
        public String windows_or_unix_port()
        {

            String port = "";
            String name = Convert.ToString(System.Environment.OSVersion);
            Console.WriteLine(System.Environment.OSVersion);
            Console.WriteLine(name.Contains("Windows"));
            if (name.Contains("Windows"))
                port = "COM10";
            else if (name.Contains("Unix"))
                port = "ttyUSB0";
            else
            {
                Console.WriteLine("Tell the software developers that they don't currently have support for this OS");
                Console.WriteLine("They should refer to the function windows_or_unix_port() in serial.cs");
                Console.WriteLine("Thanks, Dave and Ryan");
            }
            return port;
        }
    }
}