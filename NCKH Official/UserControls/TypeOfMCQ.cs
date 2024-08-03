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
    public partial class TypeOfMCQ : UserControl
    {

        public TypeOfMCQ()
        {
            InitializeComponent();
            
        }

        private void fITBBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void findIncorrectBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void fITBCounter_ValueChanged(object sender, EventArgs e)
        {

        }
        public bool IsFITBCheckBoxChecked
        {
            get { return fITBCheckBox.Checked; }
        }
        public bool IsAppropriateResponseCheckBoxChecked
        {
            get { return appropriateResponseCheckBox.Checked; }
        }
    }
}
