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
    public partial class _2ndHome : Form
    {
        public _2ndHome()
        {
            InitializeComponent();


            SectorButton.BackColor = Color.FromArgb(64, 60, 66);
            SectorButton.ForeColor = Color.FromArgb(255,138,101);

            BlockButton.BackColor = Color.FromArgb(64, 60, 66);
            BlockButton.ForeColor = Color.FromArgb(255, 138, 101);

            ClusterButton.BackColor = Color.FromArgb(64, 60, 66);
            ClusterButton.ForeColor = Color.FromArgb(255, 138, 101);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void SectorButton_Click(object sender, EventArgs e)
        {
            Sector sectorform = new Sector();
            this.Hide();
            sectorform.Show();
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            Block form = new Block();
            this.Hide();
            form.Show();
        }

        private void ClusterButton_Click(object sender, EventArgs e)
        {
            Cluster form = new Cluster();
            this.Hide();
            form.Show();
        }

        private void ComparisonButton_Click(object sender, EventArgs e)
        {
            Comparison c = new Comparison();
            this.Hide();
            c.Show();
        }

       
    }
}
