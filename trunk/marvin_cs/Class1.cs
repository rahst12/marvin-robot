using System;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace Marvin_cs
{
    class SerialComm
    {
        bool fsucccess;
        private SerialPort comm;

        public SerialComm()
        {
            comm = new SerialPort("/dev/ttyUSB0", 9600, System.IO.Ports.Parity.Mark, 8, System.IO.Ports.StopBits.One);
            comm.Open();
            fsuccess = comm.IsOpen;
            if (!fsuccess)
                Console.WriteLine("Com1 failed to open");
            else
                Console.WriteLine("/dev/ttyUSB0 opened successfully");

        }
    }
}
