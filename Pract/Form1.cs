using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pract
{
    public partial class Form1 : Form
    {
        static internal List<Student> list = new List<Student>();
        string path = Directory.GetCurrentDirectory() + "\\LabPract.txt";

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RefreshList()
        {
            listView1.Items.Clear();
            foreach (Student s in list)
            {
                if (!CheckGrants.Checked || s.HasGrants())
                    listView1.Items.Add(s.ToListItem());
            }
        }

        private void ButAddToList_Click(object sender, EventArgs e)
        {
            Form2 Add_form = new Form2();
            Add_form.Show();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void CheckGrants_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
       
        private void ButtWriteToFile_Click(object sender, EventArgs e)
        {
            int m=0, w=0;
            foreach(Student s in list) {
                if (s.Sex.Trim().ToLower().Equals("муж"))
                {
                    m++;
                }
                else {
                    w++;
                }
            }

            if (m >= 5 && w >= 5) { 
                string content = "";
                foreach (Student st in list)
                {
                    content += st.Serialize() + "\n";
                }
                File.WriteAllText(path, content);
            }
            
        }

        private void ButtReadFile_Click(object sender, EventArgs e)
        {
            string[] content = File.ReadAllLines(path);
            list.Clear();
            foreach (string s in content) {
                list.Add(new Student(s));
            }
            RefreshList();
        }

    }
}
