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
    public partial class cStudents : Form
    {
        int record_per_sector;
        int number_sector_per_cluster;
        int cluster_per_track; 
        public cStudents(int number_cluster,int number_sectors,int number_records)
        {
            InitializeComponent();
            record_per_sector = number_records;
            number_sector_per_cluster = number_sectors;
            cluster_per_track = number_cluster;
            if (true)
            {



                XmlWriter xm = XmlWriter.Create("cStudents.xml");
                xm.WriteStartDocument();
                xm.WriteStartElement("Disk");
                xm.WriteEndElement();
                xm.WriteEndDocument();
                xm.Close();

                XmlDocument Doc = new XmlDocument();
                Doc.Load("cStudents.xml");
                XmlElement track = Doc.CreateElement("track");
                Doc.DocumentElement.AppendChild(track);
                XmlElement cluster = Doc.CreateElement("cluster");
                track.AppendChild(cluster);
                XmlElement sector = Doc.CreateElement("sector");
                cluster.AppendChild(sector);
                Doc.Save("cStudents.xml");




            }


            
        }

        private void cStudents_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            XmlDocument Students = new XmlDocument();
            Students.Load("cStudents.xml");

            int N = Data.Rows.Count - 1;

            while (N > 0)
            {
                XmlElement track = (XmlElement)(Students.GetElementsByTagName("track")[Students.GetElementsByTagName("track").Count - 1]);
                XmlElement cluster = (XmlElement)(track.GetElementsByTagName("cluster")[track.GetElementsByTagName("cluster").Count - 1]);
                XmlElement sector = (XmlElement)(cluster.GetElementsByTagName("sector")[cluster.GetElementsByTagName("sector").Count - 1]);

              
                if (N != 0 && sector.GetElementsByTagName("Student").Count == record_per_sector && cluster.GetElementsByTagName("sector").Count == number_sector_per_cluster && track.GetElementsByTagName("cluster").Count == cluster_per_track)
                {
                    XmlElement Track = Students.CreateElement("track");
                    Students.DocumentElement.AppendChild(Track);


                    XmlElement Cluster = Students.CreateElement("cluster");
                    Track.AppendChild(Cluster);

                    XmlElement Sector = Students.CreateElement("sector");
                    Cluster.AppendChild(Sector);
                    track = (XmlElement)(Students.GetElementsByTagName("track")[Students.GetElementsByTagName("track").Count - 1]);
                    cluster = (XmlElement)(track.GetElementsByTagName("cluster")[track.GetElementsByTagName("cluster").Count - 1]);
                    sector = (XmlElement)(cluster.GetElementsByTagName("sector")[cluster.GetElementsByTagName("sector").Count - 1]);
                    Students.Save("cStudents.xml");
                }


                if (N != 0 && sector.GetElementsByTagName("Student").Count == record_per_sector && cluster.GetElementsByTagName("sector").Count == number_sector_per_cluster && track.GetElementsByTagName("cluster").Count < cluster_per_track)
                {

                    XmlElement Cluster = Students.CreateElement("cluster");
                    track.AppendChild(Cluster);
                   
                    XmlElement Sector = Students.CreateElement("sector");
                    Cluster.AppendChild(Sector);

                    cluster = (XmlElement)(track.GetElementsByTagName("cluster")[track.GetElementsByTagName("cluster").Count - 1]);
                    sector = (XmlElement)(cluster.GetElementsByTagName("sector")[cluster.GetElementsByTagName("sector").Count - 1]);
                    Students.Save("cStudents.xml");
                }
               
                if (N != 0 && sector.GetElementsByTagName("Student").Count == record_per_sector && cluster.GetElementsByTagName("sector").Count < number_sector_per_cluster && track.GetElementsByTagName("cluster").Count < cluster_per_track)
                {
                    XmlElement Sector = Students.CreateElement("sector");
                    cluster.AppendChild(Sector);
                    sector = (XmlElement)(cluster.GetElementsByTagName("sector")[cluster.GetElementsByTagName("sector").Count - 1]);
                    Students.Save("cStudents.xml");
                }

                while (true)
                {
                    
                    int Students_Counter = sector.GetElementsByTagName("Student").Count;

                    if (N == 0 || Students_Counter == record_per_sector)
                        break;

                    XmlElement Student = Students.CreateElement("Student");
                    Student.SetAttribute("ID", Data.Rows[Data.Rows.Count - 1 - N].Cells[0].Value.ToString());
                    Student.SetAttribute("Name", Data.Rows[Data.Rows.Count - 1 - N].Cells[1].Value.ToString());
                    Student.SetAttribute("Address", Data.Rows[Data.Rows.Count - 1 - N].Cells[2].Value.ToString());
                    sector.AppendChild(Student);
                    Students.Save("cStudents.xml");
                    N--;
                }

            }
            Students.Save("cStudents.xml");
            Data.Rows.Clear();

            MBox m = new MBox("Data has been Successfully Added", "");
            m.Show();




        }
    }
}
