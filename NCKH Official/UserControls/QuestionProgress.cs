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
using NCKH_Official.UserControls;

namespace NCKH_Official.Forms
{
    public partial class QuestionProgress : UserControl
    {
        private List<Question> Questions;
        private List<UserControl> allSpaces;
        private int type;
        public QuestionProgress(List<Question> Qs, List<UserControl> all, int Type)
        {
            InitializeComponent();
            Questions = Qs;
            allSpaces = all;
            type = Type;
        }

        private void MCProgress_Load(object sender, EventArgs e)
        {
        }
        public void SetUpProgress ()
        {
            if (type == 1)
            {
                label1.Text = "Trắc nghiệm";
            }
            if (type == 2)
            {
                label1.Text = "Trả lời ngắn";
            }
            if (type == 3)
            {
                label1.Text = "Reading";
            }
            int questionNumber = 1;
            buttonPanel.Margin = new Padding(33);
            foreach (Question question in Questions)
            {
                QuestionProgressButton questionProgressButton = new QuestionProgressButton(question, questionNumber, allSpaces);
                questionProgressButton.SetUpButton();
                buttonPanel.Controls.Add(questionProgressButton);
                
                questionNumber++;
                type = question.GeneralTypeOfQuestion;
            }

            
        }
    }
}
