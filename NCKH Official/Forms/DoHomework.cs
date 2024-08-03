using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Functions;
using NCKH_Function;
using NCKH_Official.Forms;
using NCKH_Official.UserControls;

namespace NCKH_Official
{
    public partial class DoHomework : Form
    {
        private List<Question> questions;
        public DoHomework(List<Question> listQuestions)
        {
            InitializeComponent();
            questions = listQuestions;
        }

        private void DoHomework_Load(object sender, EventArgs e)
        {
            List<Question> mCQuestions = questions.Where(q => q.GeneralTypeOfQuestion == 1).ToList();
            List<Question> sAQuestions = questions.Where(q => q.GeneralTypeOfQuestion == 2).ToList();
            List<Question> rQuestions = questions.Where(q => q.GeneralTypeOfQuestion == 3).ToList();
            if (mCQuestions != null)
            {
                int mCQuestionNumber = 1;
                
                foreach (Question mCQuestion in mCQuestions)
                {
                    MCQSpace mCQSpace = new MCQSpace(mCQuestion.IDCode,this, mCQuestions.Count);
                    mCQSpace.SetUpQuestion(mCQuestion.QuestionRequest, mCQuestion.Options, mCQuestionNumber);
                    showQuestionPanel.Controls.Add(mCQSpace);
                    mCQSpace.Location = new Point(0, 0);
                    mCQSpace.Visible = false;
                    mCQuestionNumber++;
                    showQuestionPanel.Controls.Add(mCQSpace);
                }
                
            }
            
            if (sAQuestions != null)
            {
                int sAQuestionNumber = 1;
                foreach (Question sAQuestion in sAQuestions)
                {
                    SAQSpace sAQSpace = new SAQSpace(sAQuestion.IDCode, this);
                    sAQSpace.SetUpQuestion(sAQuestion.QuestionRequest, sAQuestionNumber);
                    showQuestionPanel.Controls.Add(sAQSpace);
                    sAQSpace.Location = new Point(0, 0);
                    sAQSpace.Visible = false;
                    sAQuestionNumber++;
                }
                if (mCQuestions != null)
                {
                    
                }
                else
                {

                }
            }

            if (rQuestions != null)
            {
                int rQuestionNumber = 1;
                Question passageQuestion = questions.FirstOrDefault(p => p.SpecificTypeOfQuestion == 7);
                string? passage = passageQuestion.QuestionRequest;
                PassageSpace passageSpace = new PassageSpace(passage);
                showQuestionPanel.Controls.Add(passageSpace);
                passageSpace.Location = new Point(950, 0);
                passageSpace.Visible = false;
                foreach (Question rQuestion in rQuestions)
                {
                    var rQSpace = new RQSpace(rQuestion.IDCode, this);
                    rQSpace.SetUpQuestion(rQuestion.QuestionRequest, rQuestion.Options, rQuestionNumber, rQuestion.SpecificTypeOfQuestion);
                    showQuestionPanel.Controls.Add(rQSpace);
                    rQSpace.Location = new Point(0, 0);
                    rQSpace.Visible = false;

                }
            }
            List<UserControl> allSpaces = new List<UserControl>();
            allSpaces = showQuestionPanel.Controls.OfType<UserControl>().ToList();
            QuestionProgress mCProgress = new QuestionProgress(mCQuestions, allSpaces, 1);
            QuestionProgress sAProgress = new QuestionProgress(sAQuestions, allSpaces, 2);
            QuestionProgress rProgress = new QuestionProgress(rQuestions, allSpaces, 3);
            mCProgress.Visible = false;
            sAProgress.Visible = false;
            rProgress.Visible = false;
            progressPanel.Controls.Add(mCProgress);
            mCProgress.SetUpProgress();
            progressPanel.Controls.Add(sAProgress);
            sAProgress.SetUpProgress();
            progressPanel.Controls.Add(rProgress);
            rProgress.SetUpProgress();
            if (mCQuestions != null)
            {

                mCProgress.Visible = true;
                mCProgress.Location = new Point(0,100);
                

                if (sAQuestions != null)
                {

                    sAProgress.Visible = true;
                    sAProgress.Location = new Point(0, mCProgress.Bottom);
                    if (rQuestions != null)
                    {
                        rProgress.Visible = true;
                        rProgress.Location = new Point(0, sAProgress.Bottom);
                    }
                }
                else
                {
                    sAProgress.Visible = false;
                    if (rQuestions != null)
                    {
                        rProgress.Visible = true;
                        rProgress.Location = new Point(0, mCProgress.Bottom);
                    }
                }
            }
            else
            {
                mCProgress.Visible = false;
                if (sAQuestions != null)
                {
                    sAProgress.Visible = true;
                    sAProgress.Location = new Point(0, 0);
                    if (rQuestions != null)
                    {
                        rProgress.Visible = true;
                        rProgress.Location = new Point(0, sAProgress.Bottom);
                    }
                }
                else
                {
                    if (rQuestions != null)
                    {
                        rProgress.Visible = true;
                        rProgress.Location = new Point(0, 0);
                    }
                }
            }
            
            
        }
        public List<UserControl> GetAllSpaces
        {
            get 
            {
                List<UserControl> allSpaces = new List<UserControl>();
                allSpaces = showQuestionPanel.Controls.OfType<UserControl>().ToList();
                return allSpaces; 
            }
        }
    }
}
