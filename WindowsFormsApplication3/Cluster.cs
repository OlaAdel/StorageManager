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
    public partial class Cluster : Form
    {
        public Cluster()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _2ndHome f = new _2ndHome();
            this.Hide();
            f.Show();
        }

        private void SectorButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = null;
            if (textBox2.Text == "0")
                textBox2.Text = null;


            if (textBox4.Text == "0")
                textBox4.Text = null;
            if (textBox3.Text == "0")
                textBox3.Text = null;
            if (textBox5.Text == "0")
                textBox5.Text = null; 
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                MBox Message = new MBox("You Must Fill All Data!", "");
                Message.Show();
            }
            else    
            {

               

                int sector_Size = int.Parse(textBox1.Text);
                int cluster_Size = int.Parse(textBox2.Text);
                int track_size = int.Parse(textBox3.Text);
                int record_size = int.Parse(textBox4.Text);
                int number_sectors_per_cluster = int.Parse(textBox5.Text);


                int number_of_clusters = track_size / cluster_Size;
                int used_space = number_of_clusters * cluster_Size;
                float number_record_per_sector = sector_Size / record_size;
                int Number_record_per_sector = (int)number_record_per_sector;
                float number_record_per_cluster =  number_record_per_sector* number_sectors_per_cluster;
                int Number_record_per_cluster = (int)number_record_per_cluster;
                int number_of_records_track = number_of_clusters * Number_record_per_cluster;
                int frag = track_size - used_space;

                MBox Message = new MBox("The Amount of Fragmentation = " + frag.ToString(), "The Number of Records per Track = " + number_of_records_track.ToString());
                Message.Show();

                cStudents Simulate = new cStudents(number_of_clusters, number_sectors_per_cluster,Number_record_per_sector);
                Simulate.Show();
                this.Hide();



            }








        }

        private void Cluster_Load(object sender, EventArgs e)
        {

        }
    }
}
