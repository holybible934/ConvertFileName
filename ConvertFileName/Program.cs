﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFileName
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader table = new StreamReader(@".\table.csv");
            string line;
            while (!table.EndOfStream)
            {
                line = table.ReadLine();
                string[] filenames = line.Split(',');
                try
                {
                    System.IO.File.Move(filenames[0] + ".epub", filenames[2] + ".epub");
                    System.IO.File.Move(filenames[1] + ".jpg", filenames[2] + ".jpg");
                }
                catch (FileNotFoundException)
                {}
            }
        }
    }
}
