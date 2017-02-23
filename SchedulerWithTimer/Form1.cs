using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace SchedulerWithTimer
{
    public partial class Form1 : Form
    {
        static System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            setup_Timer();
        }

        static void setup_Timer()
        {
            Console.WriteLine("### Timer Started ###");

            DateTime nowTime = DateTime.Now;
            DateTime scheduledTime = new DateTime(nowTime.Year, nowTime.Month, nowTime.Day, 24, 48, 0, 0); //Specify your time HH,MM,SS
            if (nowTime > scheduledTime)
                scheduledTime = scheduledTime.AddDays(1);

            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;
            timer = new System.Timers.Timer(tickTime);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }

        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Console.WriteLine("### Timer Stopped ### \n\n");
            timer.Stop();
            MessageBox.Show("task start");
            //Console.WriteLine("Hello World!!! - Started executing scheduled task\n\n");
            //Console.WriteLine("### Task Finished ### \n\n");
            setup_Timer();
        }
    }
}
