using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerWithTimer
{
    public class Utility
    {
        private static string _slidePath = "";
        public static string SlidePath
        {
            get
            {
                _slidePath = Path.GetDirectoryName(Application.ExecutablePath);// +"\\images";
                _slidePath = System.IO.Path.Combine(_slidePath, @"..\..") + "\\images"; 
                try
                {
                    if (!Directory.Exists(_slidePath))
                    {
                        Directory.CreateDirectory(_slidePath);
                        //Logger.Save("directory created " + _slidePath, false);
                    }
                }
                catch (Exception ex)
                {
                    //Logger.Save("SlidePath catch Error occur " + ex.InnerException.Message, false);
                }
                return _slidePath;
            }
        }
    }
}
