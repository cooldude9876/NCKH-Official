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
    public partial class MCQSpace : UserControl
    {
        public MCQSpace()
        {
            InitializeComponent();
        }
        public void SetUpQuestion(string question, string AnswerA, string AnswerB, string AnswerC, string AnswerD, int i)
        {
            label1.Text = $"Question {i} : {question}";
            label2.Text = $"A. {AnswerA}";
            label3.Text = $"B. {AnswerB}";
            label4.Text = $"C. {AnswerC}";
            label5.Text = $"D. {AnswerD}";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
