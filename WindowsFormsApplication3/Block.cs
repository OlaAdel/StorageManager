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
    public partial class Block : Form
    {
        public Block()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _2ndHome f = new _2ndHome();
            this.Hide();
            f.Show();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            if (RecordSize.Text == "" || TrackSize.Text == "" || BlockingFactor.Text == "" || Data.Text == "")
            {
                MBox Message = new MBox("You Must Fill All Data!", "");
                Message.Show();
            }
            else
            {
                if (RecordSize.Text == "0")
                    RecordSize.Text = null;
                if (TrackSize.Text == "0")
                    TrackSize.Text = null;
            

                if (BlockingFactor.Text == "0")
                    BlockingFactor.Text = null;
                if (Data.Text == "0")
                    Data.Text = null;

                int Record_Size = int.Parse(RecordSize.Text);
                int Track_Size = int.Parse(TrackSize.Text);
                int Blocking_Factor = int.Parse(BlockingFactor.Text);
                int Non_Data = int.Parse(Data.Text);
                int Block_Size = (Blocking_Factor * Record_Size) + Non_Data;

                int Number_of_Blocks = Track_Size / Block_Size;
                int Number_of_Records_per_Track = Blocking_Factor * Number_of_Blocks;
                int User_Space = Block_Size * Number_of_Blocks;
                int Fragmentation_per_Track = Track_Size - User_Space;

                MBox Message = new MBox("The Amount of Fragmentation = " + Fragmentation_per_Track.ToString(), "The Number of Records per Track = " + Number_of_Records_per_Track.ToString());
                Message.Show();
                B_AddStudent Simulate = new B_AddStudent(Blocking_Factor, Number_of_Blocks);
                Simulate.Show();
                this.Hide();

            }
            }

        private void Block_Load(object sender, EventArgs e)
        {

        }
    }
}
