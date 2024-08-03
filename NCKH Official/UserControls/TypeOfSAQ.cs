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
    public partial class TypeOfSAQ : UserControl
    {
        public TypeOfSAQ()
        {
            InitializeComponent();
        }
        public bool IsWordFormationCheckBoxChecked
        {
            get { return wordFormationCheckBox.Checked; }
        }
        public bool IsRearrangeCheckBoxChecked
        {
            get { return rearrangeCheckBox.Checked; }
        }
        
    }
}
