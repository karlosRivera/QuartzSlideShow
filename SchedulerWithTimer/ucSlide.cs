using System;
using System.Timers;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerWithTimer
{
    public partial class ucSlide : UserControl
    {

        private int imageNumber = 1, SlideCount = 0;
        System.Timers.Timer aTimer = new System.Timers.Timer();

        public ucSlide()
        {
            InitializeComponent();

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 10000;

            aTimer.Enabled = false;
        }

        public frmMain _frmMain;
        public frmMain MainForm
        {
            get { return _frmMain; }
            set
            {
                //_frmMain = value;
                //_frmMain.FetchStart += new EventHandler(FetchStart);
                //_frmMain.FetchDone += new EventHandler(FetchDone);
                //_frmMain.NoDataFound += new EventHandler(NoDataFound);
            }
        }

        private string _SlideSource = "";
        public string SlideSource
        {
            get { return _SlideSource; }
            set
            {
                _SlideSource = value;
                SlideCount = Directory.GetFiles(_SlideSource, "*", SearchOption.AllDirectories).Length;
            }
        }

        private void FetchStart(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() => 
                {
                    aTimer.Enabled = false;
                    picSlide.SizeMode = PictureBoxSizeMode.CenterImage;
                    picSlide.Image = SchedulerWithTimer.Properties.Resources.loading;
                }));
            }
            else
            {
                aTimer.Enabled = false;
                picSlide.SizeMode = PictureBoxSizeMode.CenterImage;
                picSlide.Image = SchedulerWithTimer.Properties.Resources.loading;
            }
        }

        private void FetchDone(object sender, EventArgs e)
        {
           
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() => { aTimer.Enabled = true; }));
            }
            else
                aTimer.Enabled = true;
        }

        private void NoDataFound(object sender, EventArgs e)
        {
            picSlide.SizeMode = PictureBoxSizeMode.CenterImage;
            aTimer.Enabled = false;
            picSlide.Image = SchedulerWithTimer.Properties.Resources.nodata;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            loadNextImage();
        }

        private void loadNextImage()
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() => 
                {
                    if (imageNumber == SlideCount)
                    {
                        imageNumber = 1;
                    }
                    picSlide.SizeMode = PictureBoxSizeMode.Zoom;
                    picSlide.ImageLocation = string.Format(this.SlideSource + @"\Slide{0}.jpg", imageNumber);
                    //picSlide.Refresh();
                    imageNumber++;                
                }));
            }
            else
            {
                if (imageNumber == SlideCount)
                {
                    imageNumber = 1;
                }
                picSlide.SizeMode = PictureBoxSizeMode.Zoom;
                picSlide.ImageLocation = string.Format(this.SlideSource + @"\Slide{0}.jpg", imageNumber);
                //picSlide.Refresh();
                imageNumber++;
            }
        }
    }
}
