using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL1
{
    public partial class Form1 : Form
    {
        private Students students;
        private Subjects subjects;
        private Uspev uspev;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            students = new Students();
            students.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            subjects = new Subjects();
            subjects.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uspev=new Uspev();
            uspev.Visible = true;
        }
    }
}
