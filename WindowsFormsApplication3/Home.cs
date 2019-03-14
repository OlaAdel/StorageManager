using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StorageManager
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();




            timer.Enabled = true;
            timer.Start();
            timer.Interval = 50;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Maximum = 40;
            circularProgressBar1.ForeColor = Color.FromArgb(66, 66, 66);
            timer.Tick += new EventHandler(timer_Tick);

        
        }
        

        int waitingTime = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (circularProgressBar1.Value < 40)
            {
                circularProgressBar1.Value++;
            }
            else
            {
                if (waitingTime++ > 10)
                {
                    _2ndHome f = new _2ndHome();
                    timer.Tick -= new EventHandler(timer_Tick);
                    this.Hide();
                    f.Show();
                }
                   
            }

            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
