using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace StorageManager
{
    public partial class AddStudent : Form
    {
        int Number_of_Records_per_Sector;
        int Number_of_Records_per_Track;
        int Number_of_Sectors_per_Track;


        public AddStudent(int number_of_Records_per_Sector, int number_of_Records_per_Track,int number_of_Sectors_per_Track)
        {
            InitializeComponent();
            Number_of_Records_per_Sector=number_of_Records_per_Sector;
            Number_of_Records_per_Track = number_of_Records_per_Track;
            Number_of_Sectors_per_Track = number_of_Sectors_per_Track;

            if (true)
            {
                XmlWriter xm = XmlWriter.Create("Students.xml");
                xm.WriteStartDocument();
                xm.WriteStartElement("Disk");
                xm.WriteEndElement();
                xm.WriteEndDocument();
                xm.Close();

                XmlDocument Doc = new XmlDocument();
                Doc.Load("Students.xml");
                XmlElement Track = Doc.CreateElement("Track");
                Doc.DocumentElement.AppendChild(Track);
                XmlElement Sector = Doc.CreateElement("Sector");
                Track.AppendChild(Sector);
                Doc.Save("Students.xml");

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            XmlDocument Students= new XmlDocument();
            Students.Load("Students.xml");

            int N = Data.Rows.Count-1;

            while (N>0)
            {
                XmlElement track = (XmlElement)(Students.GetElementsByTagName("Track")[Students.GetElementsByTagName("Track").Count - 1]);
                XmlElement sector = (XmlElement)(track.GetElementsByTagName("Sector")[track.GetElementsByTagName("Sector").Count - 1]);



                if (N != 0 && sector.GetElementsByTagName("Student").Count == Number_of_Records_per_Sector && track.GetElementsByTagName("Sector").Count < Number_of_Sectors_per_Track)
                {
                    XmlElement Sector = Students.CreateElement("Sector");
                    track.AppendChild(Sector);
                    sector = (XmlElement)(track.GetElementsByTagName("Sector")[track.GetElementsByTagName("Sector").Count - 1]);
                    Students.Save("Students.xml");

                }
                if(N != 0 && sector.GetElementsByTagName("Student").Count == Number_of_Records_per_Sector && track.GetElementsByTagName("Sector").Count == Number_of_Sectors_per_Track)
                {
                    XmlElement Track = Students.CreateElement("Track");
                    Students.DocumentElement.AppendChild(Track);
                    XmlElement Sector = Students.CreateElement("Sector");
                    Track.AppendChild(Sector);
                    track = (XmlElement)(Students.GetElementsByTagName("Track")[Students.GetElementsByTagName("Track").Count - 1]);
                    sector = (XmlElement)(track.GetElementsByTagName("Sector")[track.GetElementsByTagName("Sector").Count - 1]);
                    Students.Save("Students.xml");

                }
                while (true)
                {
                    int Students_Counter = sector.GetElementsByTagName("Student").Count;

                    if (N == 0 || Students_Counter == Number_of_Records_per_Sector)
                        break;
             
                    XmlElement Student = Students.CreateElement("Student");
                    Student.SetAttribute("ID", Data.Rows[Data.Rows.Count - 1 - N].Cells[0].Value.ToString());
                    Student.SetAttribute("Name", Data.Rows[Data.Rows.Count - 1 - N].Cells[1].Value.ToString());
                    Student.SetAttribute("Address", Data.Rows[Data.Rows.Count - 1 - N].Cells[2].Value.ToString());
                    sector.AppendChild(Student);
                    Students.Save("Students.xml");


                    N--;
                }


            }

            Students.Save("Students.xml");
            Data.Rows.Clear();

            MBox m = new MBox("Data has been Successfully Added", "");
            m.Show();





        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Sector s = new Sector();
            s.Show();
            this.Hide();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
