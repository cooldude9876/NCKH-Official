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
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
            engEngButton.FillColor = Color.Gray;
            engVieButton.FillColor = Color.Gray;
        }
        bool engVieChosen = false;
        bool engEngChosen = false;

        private void engVieButton_Click(object sender, EventArgs e)
        {
            engVieButton.FillColor = Color.LightBlue;
            engEngButton.FillColor = Color.Gray;
            engEngChosen = false;
            engVieChosen = true;
        }

        private void engEngButton_Click(object sender, EventArgs e)
        {
            engVieButton.FillColor = Color.Gray;
            engEngButton.FillColor = Color.LightBlue;
            engEngChosen = true;
            engVieChosen = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;
            string context = contextBox.Text;
            string typeOfDictionary;
            if (engVieChosen)
            {
                typeOfDictionary = "Từ điển Anh - Việt";
            }
            else if (engEngChosen)
            {
                typeOfDictionary = "Từ điển Anh - Anh";
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn loại từ điển");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
