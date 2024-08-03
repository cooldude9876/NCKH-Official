using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_Official.UserControls
{
    public partial class PassageSpace : UserControl
    {
        public PassageSpace(string p)
        {
            InitializeComponent();
            passageLabel.Text = p;
        }

        private void PassageSpace_Load(object sender, EventArgs e)
        {

        }
    }
}
