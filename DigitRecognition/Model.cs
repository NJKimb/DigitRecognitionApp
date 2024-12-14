using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Digit_Recognition
{
    internal class Model
    {
        public Model() { }

        public string Python_Prediction(string file)
        {
            string result = null;
            string path = "C:\\Users\\mocil\\Source\\Repos\\DigitRecognitionApp\\DigitRecognition\\DigitRecognition\\";

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Users\\mocil\\AppData\\Local\\Programs\\Python\\Python312\\python.exe";
            start.Arguments = string.Format("{0}main.py {1} {0}dict.pth", path, file);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.RedirectStandardError = true;
            using (Process process = Process.Start(start))
            {
                using(StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                 
                }
            }
            return result;
        }
    }
}
