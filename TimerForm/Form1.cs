using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerForm
{
    public partial class Form1 : Form
    {
        private int elapsedTime = 0;
        private bool Runtime = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void RestartB_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Runtime = false;
            elapsedTime = 0;
            TimeLbl.Text = "00:00:00";
            StartB.Enabled = true;
            PauseB.Enabled = false;
            RestartB.Enabled = false;


        }

        private void StartB_Click(object sender, EventArgs e)
        {
            if (!Runtime)
            {
                timer1.Start();
                Runtime = true;
                StartB.Enabled = false;
                PauseB.Enabled = true;
                RestartB.Enabled = true;

            }
        }

        private void PauseB_Click(object sender, EventArgs e)
        {
            if (Runtime)
            {
                timer1.Stop();
                Runtime = false;
                StartB.Enabled = true;
                PauseB.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            int hours = elapsedTime / 3600; 
            int minutes = (elapsedTime % 3600) / 60; 
            int seconds = elapsedTime % 60; 

            TimeLbl.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);






        }



    }


}
