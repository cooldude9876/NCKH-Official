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
            numberOfFITB.Visible = false;
            numberOfPronunciation.Visible = false;
            numberOfStressSyllable.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (fillInTheBlankBox.Checked)
            {
                numberOfFITB.Visible = true;
            }
            else
            {
                numberOfFITB.Visible = false;
            }

            decimal totalMCQ = 0;
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value;
            }
            if (!fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfStressSyllable.Value;
            }
            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumMCQ(totalMCQ);
            }
        }

        private void pronunciationBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pronunciationBox.Checked)
            {
                numberOfPronunciation.Visible = true;
            }
            else
            {
                numberOfPronunciation.Visible = false;
            }

            decimal totalMCQ = 0;
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value;
            }
            if (!fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfStressSyllable.Value;
            }
            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumMCQ(totalMCQ);
            }
        }

        private void stressSyllableBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stressSyllableBox.Checked)
            {
                numberOfStressSyllable.Visible = true;
            }
            else
            {
                numberOfStressSyllable.Visible = false;
            }

            decimal totalMCQ = 0;
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value;
            }
            if (!fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfStressSyllable.Value;
            }
            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumMCQ(totalMCQ);
            }
        }


        private void numberOfFITB_ValueChanged(object sender, EventArgs e)
        {
            decimal totalMCQ = 0;
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value;
            }
            if (!fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfStressSyllable.Value;
            }
            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumMCQ(totalMCQ);
            }



        }

        private void numberOfPronunciation_ValueChanged(object sender, EventArgs e)
        {
            decimal totalMCQ = 0;
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value;
            }
            if (!fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfStressSyllable.Value;
            }
            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumMCQ(totalMCQ);
            }
        }

        private void numberOfStressSyllable_ValueChanged(object sender, EventArgs e)
        {
            decimal totalMCQ = 0;
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfPronunciation.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value + numberOfStressSyllable.Value;
            }
            if (fillInTheBlankBox.Checked && !pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfFITB.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value + numberOfStressSyllable.Value;
            }
            if (!fillInTheBlankBox.Checked && pronunciationBox.Checked && !stressSyllableBox.Checked)
            {
                totalMCQ = numberOfPronunciation.Value;
            }
            if (!fillInTheBlankBox.Checked && !pronunciationBox.Checked && stressSyllableBox.Checked)
            {
                totalMCQ = numberOfStressSyllable.Value;
            }
            GenerateHW parentForm = this.FindForm() as GenerateHW;
            if (parentForm != null)
            {
                parentForm.FindSumMCQ(totalMCQ);
            }
        }
    }
}
