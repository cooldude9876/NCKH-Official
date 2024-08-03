using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCKH_Official;
using NCKH_Official.UserControls;

namespace NCKH_Function
{
    public partial class MCQSpace : UserControl
    {
        private string IDCode;
        private DoHomework parent;
        public int qNumber;
        private int mCQCount;
        private List<UserControl> allSpaces;
        public MCQSpace(string code, DoHomework parentForm, int numberOfMCQs)
        {
            InitializeComponent();
            IDCode = code;
            parent = parentForm;
            mCQCount = numberOfMCQs;
            allSpaces = parent.GetAllSpaces;
        }
        public void SetUpQuestion(string question, List<string> Options, int questionNumber)
        {
            label1.Text = $"Question {questionNumber} : {question}";
            label1.AutoSize = false;
            label1.MaximumSize = new Size(1158, 0);
            label1.Size = new Size(1158, 86);
            label1.TextAlign = ContentAlignment.TopLeft;
            label1.Visible = true;

            label2.Text = $"A. {Options[0]}";
            label3.Text = $"B. {Options[1]}";
            label4.Text = $"C. {Options[2]}";
            label5.Text = $"D. {Options[3]}";
            codeLabel.Text = IDCode;
            qNumber = questionNumber;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ProcessAllQuestionProgressButtons();
        }

        private void optionBButton_CheckedChanged(object sender, EventArgs e)
        {
            ProcessAllQuestionProgressButtons();
        }

        private void optionCButton_CheckedChanged(object sender, EventArgs e)
        {
            ProcessAllQuestionProgressButtons();
        }

        private void optionDButton_CheckedChanged(object sender, EventArgs e)
        {
            ProcessAllQuestionProgressButtons();
        }
        private IEnumerable<QuestionProgressButton> FindAllQuestionProgressButtons(Control parent)
        {
            var controls = parent.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => FindAllQuestionProgressButtons(ctrl))
                           .Concat(controls)
                           .OfType<QuestionProgressButton>();
        }

        private void ProcessAllQuestionProgressButtons()
        {
            bool isQuestionDone = true;
            IEnumerable<QuestionProgressButton> questionProgressButtons = FindAllQuestionProgressButtons(parent);

            foreach (QuestionProgressButton questionProgressButton in questionProgressButtons)
            {
                if (IDCode == questionProgressButton.GetIDCode)
                {
                    questionProgressButton.SetColour(isQuestionDone);
                }

            }
        }
        private IEnumerable<MCQSpace> FindAllMCQSpaces(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is MCQSpace mCQSpace)
                {
                    yield return mCQSpace;
                }
                else if (control.HasChildren)
                {
                    foreach (var subControl in FindAllMCQSpaces(control))
                    {
                        yield return subControl;
                    }
                }
            }

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int questionNumber = qNumber;
            foreach (UserControl space in allSpaces)
            {
                space.Visible = false;
            }
            IEnumerable<MCQSpace> mCQSpaces = FindAllMCQSpaces(parent);
            if (qNumber > 1)
            {
                foreach (MCQSpace mCQSpace in mCQSpaces)
                {
                    if (questionNumber == mCQSpace.qNumber+1)
                    {
                        mCQSpace.Visible = true;
                        mCQSpace.BringToFront();
                    }
                }
            }
            else
            {
                backButton.Enabled = false;
            }
        }

        private IEnumerable<SAQSpace> FindAllSAQSpaces(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is SAQSpace sAQSpace)
                {
                    yield return sAQSpace;
                }
                else if (control.HasChildren)
                {
                    foreach (var subControl in FindAllSAQSpaces(control))
                    {
                        yield return subControl;
                    }
                }
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            int questionNumber = qNumber;
            foreach (UserControl space in allSpaces)
            {
                space.Visible = false;
            }
            IEnumerable<MCQSpace> mCQSpaces = FindAllMCQSpaces(parent);
            IEnumerable<SAQSpace> sAQSpaces = FindAllSAQSpaces(parent);
            if (qNumber < mCQSpaces.Count())
            {
                questionNumber++;
                foreach (MCQSpace mCQSpace in mCQSpaces)
                {
                    if (questionNumber == mCQSpace.qNumber)
                    {
                        
                        mCQSpace.Visible = true;
                        mCQSpace.BringToFront();
                    }
                }
            }
            else
            {
                foreach (SAQSpace sAQSpace in sAQSpaces)
                {
                    if (sAQSpace.qNumber == 1)
                    {
                        sAQSpace.Visible = true;
                        sAQSpace.BringToFront();
                    }
                }
            }
        }

        public string GetIDCode
        {
            get { return IDCode; }
        }

    }
}
