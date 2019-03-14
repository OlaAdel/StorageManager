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
    public partial class DataVisualization : Form
    {
        public DataVisualization(int S_Fragmentation_per_Track, int S_Number_of_Records_per_Track, int B_Fragmentation_per_Track, int B_Number_of_Records_per_Track,int Track_Size)
        {
            InitializeComponent();

            float B_Fragmentation = ((float)((B_Fragmentation_per_Track * 100) / (float)(Track_Size * 100))*100);
            float B_UsedSpace = 100 - B_Fragmentation;

            BlockTrack.Series["Series1"].Points.AddY(B_Fragmentation);
            BlockTrack.Series["Series1"].Points.Last().LegendText = "Fragmentation";

            BlockTrack.Series["Series1"].Points.AddY(B_UsedSpace);
            BlockTrack.Series["Series1"].Points.Last().LegendText = "Used Space";

            BlockTrack.Series["Series1"].XValueMember = "Name";
            BlockTrack.Series["Series1"].YValueMembers = "Count";
            BlockTrack.Series["Series1"].IsValueShownAsLabel = true;


            float S_Fragmentation = ((float)((S_Fragmentation_per_Track * 100) / (float)(Track_Size * 100)) * 100);
            float S_UsedSpace = 100 - S_Fragmentation;

            SectorTrack.Series["Series1"].Points.AddY(S_Fragmentation);
            SectorTrack.Series["Series1"].Points.Last().LegendText = "Fragmentation";

            SectorTrack.Series["Series1"].Points.AddY(S_UsedSpace);
            SectorTrack.Series["Series1"].Points.Last().LegendText = "Used Space";

            SectorTrack.Series["Series1"].XValueMember = "Name";
            SectorTrack.Series["Series1"].YValueMembers = "Count";
            SectorTrack.Series["Series1"].IsValueShownAsLabel = true;

            Records.Series["Series1"].Points.AddY(S_Number_of_Records_per_Track);
            Records.Series["Series1"].LegendText = "Number of_Records per Track in Sector";

            Records.Series["Series2"].Points.AddY(B_Number_of_Records_per_Track);
            Records.Series["Series2"].LegendText = "Number of_Records per Track in Block";



        
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
    }
}
