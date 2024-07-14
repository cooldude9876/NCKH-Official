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
            numberOfWordFormation.Visible = false;
            numberOfRearrange.Visible = false;
            numberOfSentenceRewrite.Visible = false;
        }


        decimal totalSAQ = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (wordFormationBox.Checked)
            {
                numberOfWordFormation.Visible = true;
            }
            else
            {
                numberOfWordFormation.Visible = false;
            }
            
            if (wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value;
            }
            if (!wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfSentenceRewrite.Value;
            }

            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumSAQ(totalSAQ);
            }
        }

        private void rearrangeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rearrangeBox.Checked)
            {
                numberOfRearrange.Visible = true;
            }
            else
            {
                numberOfRearrange.Visible = false;
            }
            
            if (wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value;
            }
            if (!wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfSentenceRewrite.Value;
            }

            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumSAQ(totalSAQ);
            }
        }

        private void sentenceRewriteBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sentenceRewriteBox.Checked)
            {
                numberOfSentenceRewrite.Visible = true;
            }
            else
            {
                numberOfSentenceRewrite.Visible = false;
            }
            
            if (wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value;
            }
            if (!wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfSentenceRewrite.Value;
            }

            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumSAQ(totalSAQ);
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            if (wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value;
            }
            if (!wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfSentenceRewrite.Value;
            }

            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumSAQ(totalSAQ);
            }
        }

        private void numberOfRearrange_ValueChanged(object sender, EventArgs e)
        {
            
            if (wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value;
            }
            if (!wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfSentenceRewrite.Value;
            }

            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumSAQ(totalSAQ);
            }
        }

        private void numberOfSentenceRewrite_ValueChanged(object sender, EventArgs e)
        {
            
            if (wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfRearrange.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value + numberOfSentenceRewrite.Value;
            }
            if (wordFormationBox.Checked && !rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfWordFormation.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value + numberOfSentenceRewrite.Value;
            }
            if (!wordFormationBox.Checked && rearrangeBox.Checked && !sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfRearrange.Value;
            }
            if (!wordFormationBox.Checked && !rearrangeBox.Checked && sentenceRewriteBox.Checked)
            {
                totalSAQ = numberOfSentenceRewrite.Value;
            }

            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumSAQ(totalSAQ);
            }
        }
        public bool isWordFormationChecked
        {
            get { return wordFormationBox.Checked; }
        }
        public bool isRearrangeChecked
        {
            get { return rearrangeBox.Checked; }
        }
        public bool isSentenceRewriteChecked
        {
            get { return sentenceRewriteBox.Checked; }
        }
        public int SAQCount
        {
            get { return Convert.ToInt32(totalSAQ); }
        }
        public int WordFormationCount
        {
            get { return Convert.ToInt32(numberOfWordFormation.Value); }
        }
        public int RearrangeCount
        {
            get { return Convert.ToInt32(numberOfRearrange.Value); }
        }
        public int SentenceRewriteCount
        {
            get { return Convert.ToInt32(numberOfSentenceRewrite.Value); }
        }
    }
}
