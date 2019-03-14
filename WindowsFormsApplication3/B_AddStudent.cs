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
    public partial class B_AddStudent : Form
    {
        int Blocking_Factor;
        int Number_of_Blocks;

        public B_AddStudent(int blocking_Factor,int number_of_Blocks)
        {            
            InitializeComponent();
            Blocking_Factor = blocking_Factor;
            Number_of_Blocks = number_of_Blocks;

            if (true)
            {
                XmlWriter xm = XmlWriter.Create("B_Students.xml");
                xm.WriteStartDocument();
                xm.WriteStartElement("Disk");
                xm.WriteEndElement();
                xm.WriteEndDocument();
                xm.Close();

                XmlDocument Doc = new XmlDocument();
                Doc.Load("B_Students.xml");
                XmlElement Track = Doc.CreateElement("Track");
                Doc.DocumentElement.AppendChild(Track);
                XmlElement Block = Doc.CreateElement("Block");
                Track.AppendChild(Block);
                Doc.Save("B_Students.xml");

            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            XmlDocument Students = new XmlDocument();
            Students.Load("B_Students.xml");

            int N = Data.Rows.Count - 1;

            while (N > 0)
            {
                XmlElement track = (XmlElement)(Students.GetElementsByTagName("Track")[Students.GetElementsByTagName("Track").Count - 1]);
                XmlElement block = (XmlElement)(track.GetElementsByTagName("Block")[track.GetElementsByTagName("Block").Count - 1]);


                if (N != 0 && block.GetElementsByTagName("Student").Count == Blocking_Factor && track.GetElementsByTagName("Block").Count < Number_of_Blocks)
                {
                    XmlElement Block = Students.CreateElement("Block");
                    track.AppendChild(Block);
                    block = (XmlElement)(track.GetElementsByTagName("Block")[track.GetElementsByTagName("Block").Count - 1]);
                    Students.Save("B_Students.xml");
                }
              

                if (N != 0 && block.GetElementsByTagName("Student").Count == Blocking_Factor && track.GetElementsByTagName("Block").Count ==Number_of_Blocks)
                {
                    XmlElement Track = Students.CreateElement("Track");
                    Students.DocumentElement.AppendChild(Track);
                    XmlElement Block = Students.CreateElement("Block");
                    Track.AppendChild(Block);
                    track = (XmlElement)(Students.GetElementsByTagName("Track")[Students.GetElementsByTagName("Track").Count - 1]);
                    block = (XmlElement)(track.GetElementsByTagName("Block")[track.GetElementsByTagName("Block").Count - 1]);
                    Students.Save("B_Students.xml");
                }


                while (true)
                {
                    int Students_Counter = block.GetElementsByTagName("Student").Count;

                    if (N == 0 || Students_Counter == Blocking_Factor)
                        break;

                    XmlElement Student = Students.CreateElement("Student");
                    Student.SetAttribute("ID", Data.Rows[Data.Rows.Count - 1 - N].Cells[0].Value.ToString());
                    Student.SetAttribute("Name", Data.Rows[Data.Rows.Count - 1 - N].Cells[1].Value.ToString());
                    Student.SetAttribute("Address", Data.Rows[Data.Rows.Count - 1 - N].Cells[2].Value.ToString());
                    block.AppendChild(Student);
                    Students.Save("B_Students.xml");
                    N--;
                }

            }
            Students.Save("Students.xml");
            Data.Rows.Clear();

            MBox m = new MBox("Data has been Successfully Added", "");
            m.Show();












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
            Block b = new Block();
            b.Show();
            this.Hide();
        }

        private void B_AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
