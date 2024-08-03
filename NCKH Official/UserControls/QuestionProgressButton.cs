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
using Functions;
using NCKH_Function;

namespace NCKH_Official.UserControls
{
    public partial class QuestionProgressButton : UserControl
    {
        private Question question;
        private int questionNumber;
        private List<UserControl> allSpaces;

        public QuestionProgressButton(Question q, int i, List<UserControl>all)
        {
            InitializeComponent();
            question = q;
            questionNumber = i;
            allSpaces = all;
        }
        public void SetUpButton()
        {
            questionButton.Text = $"{questionNumber}";
        }

        private void questionButton_Click(object sender, EventArgs e)
        {
            int typeOfQuestion = question.GeneralTypeOfQuestion;
            if (typeOfQuestion == 1)
            {
                List<MCQSpace> mCQSpaces = allSpaces.OfType<MCQSpace>().ToList();
                MCQSpace mCQSpace = mCQSpaces.FirstOrDefault(c => c.GetIDCode == question.IDCode);
                foreach (UserControl userControl in allSpaces)
                {
                    userControl.Visible = false;
                }
                mCQSpace.Visible = true;
            }
            if (typeOfQuestion == 2)
            {
                List<SAQSpace> sAQSpaces = allSpaces.OfType<SAQSpace>().ToList();
                SAQSpace sAQSpace = sAQSpaces.FirstOrDefault(c => c.GetIDCode == question.IDCode);
                foreach (UserControl userControl in allSpaces)
                {
                    userControl.Visible = false;
                }
                sAQSpace.Visible = true;
            }
            if (typeOfQuestion == 3)
            {
                List<RQSpace> rQSpaces = allSpaces.OfType<RQSpace>().ToList();
                RQSpace rQSpace = rQSpaces.FirstOrDefault(c => c.GetIDCode == question.IDCode);
                foreach (UserControl userControl in allSpaces)
                {
                    userControl.Visible = false;
                }
                rQSpace.Visible = true;
            }
        }
        public void SetColour(bool isQuestionDone)
        {
            if (isQuestionDone)
            {
                questionButton.FillColor = Color.LightSkyBlue;
            }
            else
            {
                questionButton.FillColor = Color.White;
            }
        }
        public string GetIDCode
        {
            get { return question.IDCode; }
        }
        public int GetQNumber
        {
            get { return questionNumber; }
        }

    }
}
