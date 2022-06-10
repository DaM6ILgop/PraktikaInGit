using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void OpenLoadForm_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.LastName = BoxLastName.Text;
            student.Name = BoxName.Text;
            student.FatherName = BoxFatherName.Text;
            student.Birthday = BoxDateOfRelease.Text;
            student.Sex = BoxSexMarker.Text;
            student.Math = comboBox1.Text;
            student.English = comboBox2.Text;
            student.Physics = comboBox3.Text;
            student.Disckretka = comboBox4.Text;
            student.MathLogic = comboBox5.Text;
            Form1.list.Add(student);
  
            this.Close();
        }

    }
}
