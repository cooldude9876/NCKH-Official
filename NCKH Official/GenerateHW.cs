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

namespace NCKH_Official
{
    public partial class GenerateHW : Form
    {
        public GenerateHW()
        {
            InitializeComponent();
            label3.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            TopBar topBar = new TopBar();
            topBar.Location = new Point(0, 0);
            topBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(topBar);

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
        public void Total()
        {
            int total = typeOfMCQ.MCQCount + typeOfSAQ.SAQCount;
            label6.Text = $"Tổng số câu : {total}";


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Label loadingLabel = new Label();
            loadingLabel.Text = "Loading ...";
            panel6.Controls.Add(loadingLabel);
            bool isFITBChecked = typeOfMCQ.isFITBChecked;
            bool isPronunciationChecked = typeOfMCQ.isPronunciationChecked;
            bool isStressSyllableChecked = typeOfMCQ.isStressSyllableChecked;
            bool isWordFormationChecked = typeOfSAQ.isWordFormationChecked;
            bool isRearrangeChecked = typeOfSAQ.isRearrangeChecked;
            bool isSentenceRewriteChecked = typeOfSAQ.isSentenceRewriteChecked;
            string level = "IELTS band 7.5 - 8.5";
            string topic = topicComboBox.Text;
            int FITBCount = 0;
            int PronunciationCount = 0;
            int StressSyllableCount = 0;
            StringBuilder buildTypeOfMCQ = new StringBuilder();
            if (isFITBChecked)
            {
                buildTypeOfMCQ.Append("Fill in the blank, ");
                FITBCount = typeOfMCQ.FITBCount;
            }
            if (isPronunciationChecked)
            {
                buildTypeOfMCQ.Append("Pronunctiation, ");
                PronunciationCount = typeOfMCQ.PronunciationCount;
            }
            if (isStressSyllableChecked)
            {
                buildTypeOfMCQ.Append("Different stress syllable");
                StressSyllableCount = typeOfMCQ.StressSyllableCount;
            }
            string stringTypeOfMCQ = buildTypeOfMCQ.ToString();
            int WordFormationCount = 0;
            int RearrangeCount = 0;
            int SentenceRewriteCount = 0;
            StringBuilder buildTypeOfSAQ = new StringBuilder();
            if (isWordFormationChecked)
            {
                buildTypeOfSAQ.Append("Word formation, ");
                WordFormationCount = typeOfSAQ.WordFormationCount;
            }
            if (isRearrangeChecked)
            {
                buildTypeOfSAQ.Append("Rearrange the sentence, ");
                RearrangeCount = typeOfSAQ.RearrangeCount;
            }
            if (isSentenceRewriteChecked)
            {
                buildTypeOfSAQ.Append("Rewrite the sentence.");
                SentenceRewriteCount = typeOfSAQ.SentenceRewriteCount;
            }
            string stringTypeOfSAQ = buildTypeOfSAQ.ToString();
            int MCQCount = typeOfMCQ.MCQCount;
            
            int SAQCount = typeOfSAQ.SAQCount;
            
            int totalQuestion = MCQCount + SAQCount;
            
            List<Question> homework = await MultipleChoiceQuestion.HomeworkGenerator(level, topic, stringTypeOfMCQ, stringTypeOfSAQ,totalQuestion, MCQCount, FITBCount,PronunciationCount,StressSyllableCount, SAQCount, WordFormationCount, RearrangeCount, SentenceRewriteCount, 0);
            var multipleChoiceQuestions = homework.Where(q => q.TypeOfQuestion == "Multiple Choice");
            panel6.Controls.Remove(loadingLabel);
            int i = 1;
            
            foreach (var question in multipleChoiceQuestions)
            {
                MCQSpace mCQSpace = new MCQSpace();
                mCQSpace.SetUpQuestion(question.QuestionRequest, question.AnswerA, question.AnswerB, question.AnswerC, question.AnswerD, i);
                
                panel6.Controls.Add(mCQSpace);
                mCQSpace.Location = new Point(0, (i - 1) * mCQSpace.Height);
                i++;
            }
            var shortAnswerQuestions = homework.Where(q => q.TypeOfQuestion == "Short Answer");
            int j = 1 + MCQCount;
            int k = 0;
            foreach (var question in shortAnswerQuestions)
            {
                SAQSpace sAQSpace = new SAQSpace();
                MCQSpace mCQSpace = new MCQSpace();
                sAQSpace.SetUpQuestion(question.QuestionRequest, j);
                
                panel6.Controls.Add(sAQSpace);
                sAQSpace.Location = new Point(0, MCQCount * mCQSpace.Height + k*sAQSpace.Height);
                j++;
                k++;
            }
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
