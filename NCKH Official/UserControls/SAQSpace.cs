using System;
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
    public partial class SAQSpace : UserControl
    {
        private string IDCode;
        private DoHomework parent;
        public int qNumber;
        private List<UserControl> allSpaces;
        public SAQSpace(string code, DoHomework parentForm)
        {
            InitializeComponent();
            IDCode = code;
            parent = parentForm;
            allSpaces = parent.GetAllSpaces;
        }
        public void SetUpQuestion(string question, int questionNumber)
        {
            label1.Text = $"Question {questionNumber} : {question}";
            qNumber = questionNumber;
        }

        private void SAQSpace_Load(object sender, EventArgs e)
        {

        }
        bool isQuestionDone = false;
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                isQuestionDone = false;
            }
            else
            {
                isQuestionDone = true;
            }
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
            IEnumerable<MCQSpace> mCQSpaces = FindAllMCQSpaces(parent);
            foreach (UserControl space in allSpaces)
            {
                space.Visible = false;
            }
            if (qNumber >1)
            {
                foreach (SAQSpace sAQSpace in sAQSpaces)
                {
                    if (questionNumber == sAQSpace.qNumber + 1)
                    {
                        sAQSpace.Visible = true;
                        sAQSpace.BringToFront();
                    }
                }
            }
            else
            {
                foreach (MCQSpace mCQSpace in mCQSpaces)
                {
                    if (mCQSpace.qNumber == mCQSpaces.Count())
                    {
                        mCQSpace.Visible = true;
                        mCQSpace.BringToFront();
                    }
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int questionNumber = qNumber;
            IEnumerable<SAQSpace> sAQSpaces = FindAllSAQSpaces(parent);
            IEnumerable<RQSpace> rQSpaces = FindAllRQSpaces(parent);
            foreach (UserControl space in allSpaces)
            {
                space.Visible = false;
            }
            if (qNumber < sAQSpaces.Count())
            {
                questionNumber++;
                foreach(SAQSpace sAQSpace in sAQSpaces)
                {
                    if(questionNumber == sAQSpace.qNumber)
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
                    if (rQSpace.qNumber == 1)
                    {
                        rQSpace.Visible = true;
                        rQSpace.BringToFront();
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
