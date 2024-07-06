using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_Official
{
    public partial class StudentHome : Form
    {
        public StudentHome()
        {
            InitializeComponent();
            TopBar userControl1 = new TopBar();
            this.Controls.Add(userControl1);
            userControl1.Location = new Point(0, 0);
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateHW generateHW = new GenerateHW();
            generateHW.Show();
            this.Hide();
        }
    }
}
