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
    public partial class GenerateHW : Form
    {
        public GenerateHW()
        {
            InitializeComponent();
            label3.Visible = false;
            label8.Visible = false;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GenerateHW_Load(object sender, EventArgs e)
        {

        }
        public TypeOfMCQ typeOfMCQ = new TypeOfMCQ();
        public TypeOfSAQ typeOfSAQ = new TypeOfSAQ();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            CustomPanel.Controls.Add(typeOfMCQ);
            typeOfMCQ.Visible = false;
            if (MultipleChoiceBox.Checked)
            {
                label3.Visible = true;
                typeOfMCQ.Location = new Point(20, MultipleChoiceBox.Bottom + 10);
                typeOfMCQ.Visible = true;
                ShortAnswerBox.Top = typeOfMCQ.Bottom + 10;
                label8.Location = new Point(155, ShortAnswerBox.Top);
                if (ShortAnswerBox.Checked)
                {

                    ReadingBox.Location = new Point(5, 385);
                    typeOfSAQ.Location = new Point(20, ShortAnswerBox.Bottom + 10);

                    label9.Location = new Point(155, ReadingBox.Top);
                }
                else
                {
                    ReadingBox.Top = ShortAnswerBox.Top + 43;
                    label9.Location = new Point(155, ReadingBox.Top);
                }
            }
            else
            {
                label3.Visible = false;
                typeOfMCQ.Visible = false;
                ShortAnswerBox.Top = MultipleChoiceBox.Top + 43;
                label8.Location = new Point(155, ShortAnswerBox.Top);
                if (ShortAnswerBox.Checked)
                {

                    ReadingBox.Location = new Point(5, typeOfSAQ.Bottom + 10);
                    label9.Location = new Point(155, ReadingBox.Top);
                }
                else
                {
                    ReadingBox.Top = ShortAnswerBox.Top + 43;
                    label9.Location = new Point(155, ReadingBox.Top);
                }
            }



        }

        private void ShortAnswerBox_CheckedChanged(object sender, EventArgs e)
        {
            CustomPanel.Controls.Add(typeOfSAQ);
            typeOfSAQ.Visible = false;
            if (ShortAnswerBox.Checked)
            {
                label8.Visible = true;
                typeOfSAQ.Location = new Point(20, ShortAnswerBox.Bottom + 10);
                typeOfSAQ.Visible = true;
                ReadingBox.Location = new Point(5, typeOfSAQ.Bottom + 10);
                label9.Location = new Point(155, ReadingBox.Top);
            }
            else
            {
                label8.Visible = false;
                typeOfSAQ.Visible = false;
                ReadingBox.Top = ShortAnswerBox.Top + 43;
                label9.Location = new Point(155, ReadingBox.Top);
            }
        }
        public void FindSumMCQ(decimal totalMCQ)
        {
            label3.Text = $"Tổng : {totalMCQ}";
        }
        public void FindSumSAQ(decimal totalSAQ)
        {
            label8.Text = $"Tổng : {totalSAQ}";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
