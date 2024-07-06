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
    public partial class TopBar : UserControl
    {
        public TopBar()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GenerateHW generateHW = new GenerateHW();
            generateHW.Show();
            Form parentForm = this.FindForm();
            parentForm.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StudentHome studentHome = new StudentHome();
            studentHome.Show();
            Form parentForm = this.FindForm();
            parentForm.Hide();
        }

        private void WritingButton_Click(object sender, EventArgs e)
        {

        }

        private void DictionaryButton_Click(object sender, EventArgs e)
        {
            Dictionary dictionary = new Dictionary();
            dictionary.Show();
            Form parentForm = this.FindForm();
            parentForm.Hide();
        }
    }
}
