using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using visualization2.Properties;

namespace visualization2
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = (int)Settings.Default["w"]; //считываем значения
            int h = (int)Settings.Default["h"];

            Console.SetWindowSize(w, h);
            Console.WriteLine("w={0} h={1}", w, h);

            Settings.Default["w"] = w + 1;
            Settings.Default["h"] = h + 1;
            Settings.Default.Save(); //сохраняем новые значения

            Console.ReadKey();
        }

    }
}
