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
    public partial class Comparison : Form
    {
        public Comparison()
        {
            InitializeComponent();
        }
        int S_Fragmentation_per_Track;
        int S_Number_of_Records_per_Track;
        public void CalcSector()
        {
            int Sector_Size = int.Parse(SectorSize.Text);
            int Record_Size = int.Parse(RecordSize.Text);
            int Track_Size = int.Parse(TrackSIze.Text);
            int Number_of_Records = int.Parse(FileSize.Text);


            int Number_of_Sectors_per_Track = Track_Size / Sector_Size;
            float Number_of_Records_per_Sector = (float)Sector_Size / Record_Size;

            float Number_of_Records_per_Track = (float)Number_of_Records_per_Sector * Number_of_Sectors_per_Track;
            S_Number_of_Records_per_Track = (int)Number_of_Records_per_Track;
            float Difference = (float)Number_of_Records_per_Track - S_Number_of_Records_per_Track;
            S_Fragmentation_per_Track = (int)(Difference * Record_Size);
        }
        int B_Fragmentation_per_Track;
        int B_Number_of_Records_per_Track;
        int Track_Size;
        public void CalcBlock()
        {
            int Record_Size = int.Parse(RecordSize.Text);
            Track_Size = int.Parse(TrackSIze.Text);
            int block_fact = int.Parse(BlockingFactor.Text);
            int non_data = int.Parse(Data.Text);
            int blocksize = (block_fact * Record_Size) + non_data;

            int Number_of_Blocks = Track_Size / blocksize;
            int num_of_blocks = Track_Size / blocksize;
            B_Number_of_Records_per_Track = block_fact * num_of_blocks;
            int usedsize = blocksize * num_of_blocks;
            B_Fragmentation_per_Track = Track_Size - usedsize;
        }


        private void CompareButton_Click(object sender, EventArgs e)
        {
            if (RecordSize.Text == "" || SectorSize.Text == "" || FileSize.Text == "" || TrackSIze.Text == "" || BlockingFactor.Text == "" || Data.Text == "")
            {
                MBox Message = new MBox("You Must Fill All Data!", "");
                Message.Show();
            }
            else
            {
                if (RecordSize.Text == "0")
                    RecordSize.Text = null;

                if (SectorSize.Text == "0")
                    SectorSize.Text = null;

                if (TrackSIze.Text == "0")
                    TrackSIze.Text = null;

                if (FileSize.Text == "0")
                    FileSize.Text = null;

                if (BlockingFactor.Text == "0")
                    BlockingFactor.Text = null;

                if (Data.Text == "0")
                    Data.Text = null;

                CalcBlock();
                CalcSector();
                ComparisonResult c = new ComparisonResult(S_Fragmentation_per_Track, S_Number_of_Records_per_Track, B_Fragmentation_per_Track, B_Number_of_Records_per_Track,Track_Size);
                this.Hide();
                c.Show();


            }


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
            _2ndHome Home = new _2ndHome();
            Home.Show();
            this.Hide();
        }
    }
}
