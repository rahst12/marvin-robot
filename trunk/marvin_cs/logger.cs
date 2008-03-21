using System;
using System.Collections.Generic;
using System.Text;
using Marvin_cs;
using System.IO;

namespace Marvin_cs
{
    public class Logger
    {
        FileStream fileStream;
        StreamWriter streamWriter;
        public delegate void LogHandler(string message);

        // Constructor
        public Logger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Create);
            streamWriter = new StreamWriter(fileStream);
        }

        // Member Function which is used in the Delegate
        public void Log(string s)
        {
            Console.WriteLine(s);
            streamWriter.WriteLine(s);
        }

        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }
    }
}
