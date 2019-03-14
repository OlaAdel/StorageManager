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
    public partial class MBox : Form
    {
        public MBox(string Fragmentation,string Records)
        {
            InitializeComponent();
            FragmenatationLabel.Text = Fragmentation;
            RecordsLabel.Text = Records;


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
