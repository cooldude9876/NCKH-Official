using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_Function
{
    public partial class SAQSpace : UserControl
    {
        public SAQSpace()
        {
            InitializeComponent();
        }
        public void SetUpQuestion (string question, int i)
        {
            label1.Text = $"Question {i} : {question}";
        }
    }
}
