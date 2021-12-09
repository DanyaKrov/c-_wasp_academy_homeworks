using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace bot0
{
    public class Results
    {
        string textfile = "scores.txt";
        string line;
        public string Read(string user)
        {
            if (File.Exists(textfile))
            {
                StreamReader sr = new StreamReader($"C:\\{textfile}");
                line = sr.ReadLine();
                while (line != user)
                {
                    line = sr.ReadLine();
                }
                line = sr.ReadLine();
                sr.Close();
                return line;
            }
            else
                return "";
        }
        public string Write(string user)
        {
            if (File.Exists(textfile))
            {
                StreamWriter sr = new StreamWriter($"C:\\{textfile}");
                sr.Close();
                return line="";
            }
            else
                return "";
        }
    }
}
