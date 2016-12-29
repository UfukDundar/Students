using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.Name = "Ufuk";
            student1.surname = "Dündar";
            student1.studentNumber = 111;

            Student student2 = new Student();
            student2.Name = "Gizem";
            student2.surname = "Dündar";
            student2.studentNumber = 123;
            MessageBox.Show("Welcome " + student1.Name + " " + student1.surname + " " + student1.studentNumber);
        }
    }
}
