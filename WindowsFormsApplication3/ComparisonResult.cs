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
    public partial class ComparisonResult : Form
    {
        int s_Fragmentation_per_Track;
        int s_Number_of_Records_per_Track;

        int b_Fragmentation_per_Track;
        int b_Number_of_Records_per_Track;

        int track_Size;



        public ComparisonResult(int S_Fragmentation_per_Track,int S_Number_of_Records_per_Track, int B_Fragmentation_per_Track,int B_Number_of_Records_per_Track, int Track_size)
        {
            InitializeComponent();
            s_Fragmentation_per_Track = S_Fragmentation_per_Track;
            s_Number_of_Records_per_Track = S_Number_of_Records_per_Track;

            b_Fragmentation_per_Track = B_Fragmentation_per_Track;
            b_Number_of_Records_per_Track = B_Number_of_Records_per_Track;
            track_Size = Track_size;





            if (S_Number_of_Records_per_Track > B_Number_of_Records_per_Track)
                Result.Text = "Sector Model is Most Efficient for this Data";
            else
                Result.Text = "Block Model is Most Efficient for this Data";


                S_Fragmentation.Text ="The Amount of Fragmentation = " +S_Fragmentation_per_Track.ToString();
                S_Record.Text ="The Number of Records per Track = " +S_Number_of_Records_per_Track.ToString();

                B_Fragmentation.Text = "The Amount of Fragmentation = " + B_Fragmentation_per_Track.ToString();
                B_Record.Text = "The Number of Records per Track = " + B_Number_of_Records_per_Track.ToString();




        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Comparison c = new Comparison();
            this.Hide();
            c.Show();
        }

        private void VisualButton_Click(object sender, EventArgs e)
        {
            DataVisualization d = new DataVisualization(s_Fragmentation_per_Track, s_Number_of_Records_per_Track, b_Fragmentation_per_Track, b_Number_of_Records_per_Track, track_Size);
            this.Hide();
            d.Show();
        }

    }
}
