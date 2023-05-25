using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiProgressBar
{
    public partial class Form1 : Form
    {
        private int dt = 10, start = 0;
        private int min = 0, max = 0;

        private bool isRunning = false;
        private bool isUp = true;
        public Form1()
        {
            InitializeComponent();
            CPB_Reset();
        }
        private void CPB_Reset()
        {
            multiProgressBar1.Value =
                multiProgressBar2.Value =
                multiProgressBar3.Value =
                multiProgressBar4.Value =
                multiProgressBar5.Value =
                multiProgressBar6.Value = 0;

            multiProgressBar1.Min_Val =
                multiProgressBar2.Min_Val =
                multiProgressBar3.Min_Val =
                multiProgressBar4.Min_Val =
                multiProgressBar5.Min_Val =
                multiProgressBar6.Min_Val = 0;

            multiProgressBar1.Max_Val =
                multiProgressBar2.Max_Val =
                multiProgressBar3.Max_Val =
                multiProgressBar4.Max_Val =
                multiProgressBar5.Max_Val =
                multiProgressBar6.Max_Val = 100;
        }
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (isRunning)
            {
                if (isUp)
                {
                    start++;
                    multiProgressBar1.Value =
                        multiProgressBar2.Value =
                        multiProgressBar3.Value =
                        multiProgressBar4.Value =
                        multiProgressBar5.Value =
                        multiProgressBar6.Value = start;
                    if (start >= multiProgressBar1.Max_Val)
                    {
                        isUp = false;
                    }
                }
            }
            if (!isUp)
            {
                start--;
                multiProgressBar1.Value =
                    multiProgressBar2.Value =
                    multiProgressBar3.Value =
                    multiProgressBar4.Value =
                    multiProgressBar5.Value =
                    multiProgressBar6.Value = start;
                if (start <= multiProgressBar1.Min_Val)
                {
                    isUp = true;
                }
            }
        }

        private void btn_Start_Stop_Click(object sender, EventArgs e)
        {
            if (btn_Start_Stop.Text == "Start")
            {
                start = 0;
                isRunning = true;
                MainTimer.Start();
                btn_Start_Stop.Text = "Stop";
            }
            else
            {
                start = 0;
                isRunning = false;
                MainTimer.Stop();
                btn_Start_Stop.Text = "Start";
                CPB_Reset();
            }
        }
    }
}
