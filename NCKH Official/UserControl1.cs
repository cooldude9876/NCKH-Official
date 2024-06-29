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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GenerateHW generateHW = new GenerateHW();

            generateHW.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StudentHome studentHome = new StudentHome();
            studentHome.Show();
            this.Hide();
        }
    }
}
