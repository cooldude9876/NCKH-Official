using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using NCKH_Function;

namespace NCKH_Official.UserControls
{
    public partial class RQSpace : UserControl
    {
        private string IDCode;
        public int qNumber;
        private DoHomework parent;
        private List<UserControl> allSpaces;
        public RQSpace(string code, DoHomework parentForm)
        {
            InitializeComponent();
            IDCode = code;
            parent = parentForm;
            allSpaces = parent.GetAllSpaces;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void SetUpQuestion(string questionRequest, List<string> options, int questionNumber, int type)
        {
            label1.Text = $"Question {questionNumber} : {questionRequest}";
            if (type == 5)
            {
                label2.Text = options[0];
                label3.Text = options[1];
                label4.Text = options[2];
                label5.Text = options[3];
                label6.Text = IDCode;
            }
            else if (type ==6)
            {
                label2.Text = options[0];
                label3.Text = options[1];
                label4.Visible = false;
                label5.Visible = false;
                optionCButton.Visible = false;
                optionDButton.Visible = false;
            }
            else
            {

            }
            qNumber = questionNumber;

        }

        private void guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ProcessAllQuestionProgressButtons();
        }

        private void optionAButton_CheckedChanged(object sender, EventArgs e)
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
        private IEnumerable<RQSpace> FindAllRQSpaces(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is RQSpace RQSpace)
                {
                    yield return RQSpace;
                }
                else if (control.HasChildren)
                {
                    foreach (var subControl in FindAllRQSpaces(control))
                    {
                        yield return subControl;
                    }
                }
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            int questionNumber = qNumber;
            IEnumerable<SAQSpace> sAQSpaces = FindAllSAQSpaces(parent);
            IEnumerable<RQSpace> rQSpaces = FindAllRQSpaces(parent);
            foreach (UserControl space in allSpaces)
            {
                space.Visible = false;
            }
            if (qNumber == 1)
            {
                foreach (SAQSpace sAQSpace in sAQSpaces)
                {
                    if (sAQSpace.qNumber == sAQSpaces.Count())
                    {
                        sAQSpace.Visible = true;
                        sAQSpace.BringToFront();
                    }
                }
            }
            else
            {
                foreach (RQSpace rQSpace in rQSpaces)
                {
                    if (questionNumber == rQSpace.qNumber++)
                    {
                        rQSpace.Visible = true;
                        rQSpace.BringToFront();
                    }
                }
            }
        }

        private void RQSpace_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int questionNumber = qNumber;
            IEnumerable<RQSpace> rQSpaces = FindAllRQSpaces(parent);
            foreach (UserControl space in allSpaces)
            {
                space.Visible = false;
            }
            if (questionNumber < rQSpaces.Count())
            {
                foreach (RQSpace rQSpace in rQSpaces)
                {
                    if (questionNumber == rQSpace.qNumber--)
                    {
                        rQSpace.Visible = true;
                        rQSpace.BringToFront();
                    }
                }
            }
            else
            {
                nextButton.Enabled = false;
            }
        }

        public string GetIDCode
        {
            get { return IDCode; }
        }
    }
}
