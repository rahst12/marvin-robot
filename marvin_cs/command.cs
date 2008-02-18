using System;
using System.Collections.Generic;
using System.Text;

namespace Marvin_cs
{
    class command
    {
        private int motor, action, seconds;
        SerialComm sh = new SerialComm();
        public char[] buffer = new char[4];

        public command()
        {
            
        }

        public void write()
        {
            buffer='1';//, '2', '3';
            char.Parse(1);
            sh.serial_write(buffer);
        }

    }
}
