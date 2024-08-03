using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
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
        private Label nullTopicErrorLabel;
        private Label noTypeOfMCQChosen;
        private Label noTypeOfQuestionChosen;
        private Label noTypeOfSAQChosen;
        private Label noTypeOfRQChosen;
        private SuggestTopicButtons suggestTopicButtons;
        public GenerateHW()
        {
            InitializeComponent();
            suggestTopicButtons = new SuggestTopicButtons(this);
            customPanel.Controls.Add(typeOfMCQ);
            customPanel.Controls.Add(typeOfSAQ);
            customPanel.Controls.Add(typeOfRQ);
            typeOfMCQ.Visible = false;
            typeOfSAQ.Visible = false;
            typeOfRQ.Visible = false;
            MCCounter.Visible = false;
            SACounter.Visible = false;
            RCounter.Visible = false;
            nullTopicErrorLabel = new Label();
            nullTopicErrorLabel.Visible = false;
            nullTopicErrorLabel.ForeColor = Color.Red;
            nullTopicErrorLabel.Text = "Bạn chưa nhập chủ đề, vui lòng nhập lại";
            nullTopicErrorLabel.AutoSize = true;
            nullTopicErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12);
            this.Controls.Add(nullTopicErrorLabel);
            noTypeOfMCQChosen = new Label();
            noTypeOfMCQChosen.Visible = false;
            noTypeOfMCQChosen.ForeColor = Color.Red;
            noTypeOfMCQChosen.Text = "Chưa chọn thể loại câu Trắc nghiệm";
            noTypeOfMCQChosen.AutoSize = true;
            noTypeOfMCQChosen.Font = new System.Drawing.Font("Segoe UI", 12);
            this.Controls.Add(noTypeOfMCQChosen);
            noTypeOfQuestionChosen = new Label();
            noTypeOfQuestionChosen.Visible = false;
            noTypeOfQuestionChosen.ForeColor = Color.Red;
            noTypeOfQuestionChosen.Text = "Chưa chọn thể loại câu nào hết";
            noTypeOfQuestionChosen.AutoSize = true;
            noTypeOfQuestionChosen.Font = new System.Drawing.Font("Segoe UI", 12);
            this.Controls.Add(noTypeOfQuestionChosen);
            noTypeOfSAQChosen = new Label();
            noTypeOfSAQChosen.Visible = false;
            noTypeOfSAQChosen.ForeColor = Color.Red;
            noTypeOfSAQChosen.Text = "Chưa chọn thể loại câu Trả lời ngắn";
            noTypeOfSAQChosen.AutoSize = true;
            noTypeOfSAQChosen.Font = new System.Drawing.Font("Segoe UI", 12);
            this.Controls.Add(noTypeOfSAQChosen);
            noTypeOfRQChosen = new Label();
            noTypeOfRQChosen.Visible = false;
            noTypeOfRQChosen.ForeColor = Color.Red;
            noTypeOfRQChosen.Text = "Chưa chọn thể loại câu Reading";
            noTypeOfRQChosen.AutoSize = true;
            noTypeOfRQChosen.Font = new System.Drawing.Font("Segoe UI", 12);
            this.Controls.Add(noTypeOfRQChosen);

        }
        private void SetLocation()
        {

            if (MCCheckBox.Checked)
            {
                typeOfMCQ.Top = MCCheckBox.Bottom + 24;
                SACheckBox.Top = typeOfMCQ.Bottom + 24;

            }
            else
            {
                SACheckBox.Top = MCCheckBox.Top + 67;
            }
            if (SACheckBox.Checked)
            {
                typeOfSAQ.Top = SACheckBox.Bottom + 24;
                RCheckBox.Top = typeOfSAQ.Bottom + 24;
            }
            else
            {
                RCheckBox.Top = SACheckBox.Top + 67;
            }
            if (RCheckBox.Checked)
            {
                typeOfRQ.Top = RCheckBox.Bottom + 24;
                noTypeOfQuestionChosen.Top = typeOfRQ.Bottom + 19;
            }
            else
            {
                noTypeOfQuestionChosen.Top = RCheckBox.Top + 67;
            }
            MCCounter.Top = MCCheckBox.Top + 6;
            SACounter.Top = SACheckBox.Top + 6;
            RCounter.Top = RCheckBox.Top + 6;
            noTypeOfMCQChosen.Top = MCCheckBox.Top;
            noTypeOfSAQChosen.Top = SACheckBox.Top;
            noTypeOfRQChosen.Top = RCheckBox.Top;
        }
        TypeOfMCQ typeOfMCQ = new TypeOfMCQ();
        TypeOfSAQ typeOfSAQ = new TypeOfSAQ();
        TypeOfRQ typeOfRQ = new TypeOfRQ();
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (MCCheckBox.Checked)
            {
                typeOfMCQ.Visible = true;
                typeOfMCQ.Location = new Point(0, MCCheckBox.Bottom + 24);
                MCCounter.Visible = true;

            }
            else
            {
                typeOfMCQ.Visible = false;
                MCCounter.Visible = false;

            }
            SetLocation();
        }

        private async void generateButton_Click(object sender, EventArgs e)
        {
            bool noError = false;
           
            if (string.IsNullOrWhiteSpace(topicTextBox.Text))
            {
                customPanel.Controls.Add(nullTopicErrorLabel);
                nullTopicErrorLabel.Location = new Point(219, topicTextBox.Top + 76);
                nullTopicErrorLabel.Visible = true;
                if (customPanel.Controls.Contains(suggestTopicButtons))
                {
                    suggestTopicButtons.Location = new Point(0, nullTopicErrorLabel.Bottom + 24);
                    MCCheckBox.Top = suggestTopicButtons.Bottom + 24;
                    SetLocation();
                }
                else
                {
                    MCCheckBox.Location = new Point(85, 224);
                    SetLocation();
                }
            }
            else
            {
                nullTopicErrorLabel.Visible = false;
                if (customPanel.Controls.Contains(suggestTopicButtons))
                {
                    suggestTopicButtons.Location = new Point(0, topicTextBox.Bottom + 24);
                    MCCheckBox.Top = suggestTopicButtons.Bottom + 24;
                    SetLocation();
                }
                else
                {
                    MCCheckBox.Location = new Point(85, 224);
                    SetLocation();
                }
            }
            if (MCCheckBox.Checked)
            {
                if (!typeOfMCQ.IsFITBCheckBoxChecked && !typeOfMCQ.IsAppropriateResponseCheckBoxChecked)
                {
                    noTypeOfMCQChosen.Location = new Point(MCCounter.Left + 129, MCCheckBox.Top);
                    customPanel.Controls.Add(noTypeOfMCQChosen);
                    noTypeOfMCQChosen.Visible = true;
                    
                }
                else
                {
                    noTypeOfMCQChosen.Visible = false;
                }
            }
            if (SACheckBox.Checked)
            {
                if (!typeOfSAQ.IsWordFormationCheckBoxChecked && !typeOfSAQ.IsRearrangeCheckBoxChecked)
                {
                    noTypeOfSAQChosen.Location = new Point(SACounter.Left + 129, SACheckBox.Top);
                    customPanel.Controls.Add(noTypeOfSAQChosen);
                    noTypeOfSAQChosen.Visible = true;
                }
                else
                {
                    noTypeOfSAQChosen.Visible = false;
                }
            }
            if (RCheckBox.Checked)
            {
                if (!typeOfRQ.IsMainIdeaCheckBoxChecked && !typeOfRQ.IsTrueFalseCheckBoxChecked)
                {
                    noTypeOfRQChosen.Location = new Point(RCounter.Left + 129, RCheckBox.Top);
                    customPanel.Controls.Add(noTypeOfRQChosen);
                    noTypeOfRQChosen.Visible = true;
                }
                else
                {
                    noTypeOfRQChosen.Visible = false;
                }
            }
            if(!MCCheckBox.Checked && !SACheckBox.Checked && !RCheckBox.Checked)
            {
                noTypeOfQuestionChosen.Location = new Point(RCheckBox.Left, RCheckBox.Bottom + 24);
                customPanel.Controls.Add(noTypeOfQuestionChosen);
                noTypeOfQuestionChosen.Visible = true;

            }
            else
            {
                noTypeOfQuestionChosen.Visible = false;
            }
            StringBuilder buildMCTypes = new StringBuilder();
            StringBuilder buildSATypes = new StringBuilder();
            StringBuilder buildRTypes = new StringBuilder();
            if (typeOfMCQ.IsFITBCheckBoxChecked)
            {
                buildMCTypes.Append("Fill in the blank, ");
            }
            if (typeOfMCQ.IsAppropriateResponseCheckBoxChecked)
            {
                buildMCTypes.Append("Appropriate Response.");
            }
            if (typeOfSAQ.IsWordFormationCheckBoxChecked)
            {
                buildSATypes.Append("Word Formation, ");
            }
            if (typeOfSAQ.IsRearrangeCheckBoxChecked)
            {
                buildSATypes.Append("Rearrange.");
            }
            if (typeOfRQ.IsMainIdeaCheckBoxChecked)
            {
                buildRTypes.Append("Main idea, ");
            }
            if (typeOfRQ.IsTrueFalseCheckBoxChecked)
            {
                buildRTypes.Append("True/False.");
            }
            if(noTypeOfQuestionChosen.Visible | noTypeOfMCQChosen.Visible | noTypeOfSAQChosen.Visible | noTypeOfRQChosen.Visible | nullTopicErrorLabel.Visible)
            {
                noError = false;
            }
            else
            {
                noError = true;
            }
            string mCTypes = buildMCTypes.ToString();
            string sATypes = buildSATypes.ToString();
            string rTypes = buildRTypes.ToString();
            string level = "IELTS band 7-8";
            string topic = topicTextBox.Text;
            List<Question> questions = new List<Question>();
            int MCCount = Convert.ToInt32(MCCounter.Value);
            int SACount = Convert.ToInt32(SACounter.Value);
            int RCount = Convert.ToInt32(RCounter.Value);
            if (noError)
            {
                questions = await Generator.HomeworkGenerator(level, topic, mCTypes, sATypes, rTypes, MCCount, SACount, RCount, MCCheckBox.Checked, typeOfMCQ.IsFITBCheckBoxChecked, typeOfMCQ.IsAppropriateResponseCheckBoxChecked, SACheckBox.Checked, typeOfSAQ.IsWordFormationCheckBoxChecked, typeOfSAQ.IsRearrangeCheckBoxChecked, RCheckBox.Checked, typeOfRQ.IsMainIdeaCheckBoxChecked, typeOfRQ.IsTrueFalseCheckBoxChecked);
                DoHomework doHomework = new DoHomework(questions);
                doHomework.Show();
                this.Hide();
            }
            
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string level = "IELTS band 7-8";
            List<string> suggestedTopics = await Generator.SuggestTopic(level);

            suggestTopicButtons.SetUpButtons(suggestedTopics);
            customPanel.Controls.Add(suggestTopicButtons);
            typeOfMCQ.Top = MCCheckBox.Top + 24;
            if (nullTopicErrorLabel.Visible)
            {
                suggestTopicButtons.Location = new Point(0, nullTopicErrorLabel.Bottom + 24);

            }
            else
            {
                suggestTopicButtons.Location = new Point(0, topicTextBox.Bottom + 24);
            }
            MCCheckBox.Top = suggestTopicButtons.Bottom + 24;
            SetLocation();

        }

        public void AutoWriteSuggestedTopic(string topic)
        {
            topicTextBox.Text = topic;
        }

        private void SACheckBox_CheckedChanged(object sender, EventArgs e)
        {


            if (SACheckBox.Checked)
            {
                SACounter.Visible = true;
                typeOfSAQ.Location = new Point(0, SACheckBox.Bottom + 24);
                typeOfSAQ.Visible = true;
            }
            else
            {
                SACounter.Visible = false;
                typeOfSAQ.Visible = false;
            }
            SetLocation();

        }

        private void RCheckBox_CheckedChanged(object sender, EventArgs e)
        {


            if (RCheckBox.Checked)
            {
                RCounter.Visible = true;
                typeOfRQ.Location = new Point(0, RCheckBox.Bottom + 24);
                typeOfRQ.Visible = true;
            }
            else
            {
                RCounter.Visible = false;
                typeOfRQ.Visible = false;
            }
            SetLocation();
        }
    }
}
