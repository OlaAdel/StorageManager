

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
    public partial class Sector : Form
    {
        public Sector()
        {
            InitializeComponent();
           

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
            _2ndHome f = new _2ndHome();
            this.Hide();
            f.Show();
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            if (RecordSize.Text == "" || SectorSize.Text == "" || FileSize.Text == "" || TrackSIze.Text == "")
            {
                MBox Message = new MBox("You Must Fill All Data!","");
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



                int Sector_Size = int.Parse(SectorSize.Text);
                int Record_Size = int.Parse(RecordSize.Text);
                int Track_Size = int.Parse(TrackSIze.Text);
                int Number_of_Records = int.Parse(FileSize.Text);


                int Number_of_Sectors_per_Track = Track_Size / Sector_Size;
           

               

                if (radioButton1.Checked == true)
                {


                    float Number_of_Records_per_Sector =(float) Sector_Size / Record_Size;
                    int number_of_Records_per_Sector = (int)Number_of_Records_per_Sector;

                    float Number_of_Records_per_Track= (float)Number_of_Records_per_Sector * Number_of_Sectors_per_Track;
                    int Number_of_Records_per_Track_Integer = (int)Number_of_Records_per_Track;
                    float Difference =(float)Number_of_Records_per_Track - Number_of_Records_per_Track_Integer;
                    int Fragmentation_per_Track = (int)(Difference * Record_Size);

                    MBox Message = new MBox("The Amount of Fragmentation = " + Fragmentation_per_Track.ToString(), "The Number of Records per Track = " + Number_of_Records_per_Track_Integer.ToString()); ;
                    Message.Show();

                    AddStudent S = new AddStudent(number_of_Records_per_Sector, Number_of_Records_per_Track_Integer, (int)Track_Size / Sector_Size);
                    S.Show();
                    this.Hide();
              


                }

                // if not span 
                else if (radioButton2.Checked == true)
                {
                    int Number_of_Records_per_Sector = Sector_Size / Record_Size;
                    int Number_of_Records_per_Track = Number_of_Records_per_Sector * Number_of_Sectors_per_Track;
                    int Fragmentation_per_Sector = Sector_Size - (Number_of_Records_per_Sector * Record_Size);

                    int Fragmentation_per_Track = Fragmentation_per_Sector * (Track_Size / Sector_Size);



                    MBox Message = new MBox("The Amount of Fragmentation = " + Fragmentation_per_Track.ToString(), "The Number of Records per Track = " + Number_of_Records_per_Track.ToString()); ;
                    Message.Show();
                    AddStudent S = new AddStudent(Number_of_Records_per_Sector, Number_of_Records_per_Track,(int)Track_Size/Sector_Size);
                    S.Show();
                    this.Hide();
                 
                }
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {

                    MBox Message = new MBox("You Must Choose any of The Two Radio Buttons!",""); ;
                    Message.Show();
                    


                }
            }
        }

        private void Sector_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FileSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
