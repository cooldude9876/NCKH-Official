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
    public partial class SuggestTopicButtons : UserControl
    {
        private GenerateHW parent;
        public SuggestTopicButtons(GenerateHW parentForm)
        {
            InitializeComponent();
            parent = parentForm;
            topicButton1.AutoSize = true;
            topicButton2.AutoSize = true;
            topicButton3.AutoSize = true;
            topicButton4.AutoSize = true;
        }

        private void SuggestTopicButtons_Load(object sender, EventArgs e)
        {

        }
        public void SetUpButtons(List<string> topics)
        {
            topicButton1.Text = topics[0];
            topicButton2.Text = topics[1];
            topicButton3.Text = topics[2];
            topicButton4.Text = topics[3];
            topicButton2.Location = new Point(topicButton1.Right + 24, topicButton1.Top);
            topicButton4.Location = new Point(topicButton3.Right + 24, topicButton3.Top);
        }
        bool topicButton1Clicked = false;
        bool topicButton2Clicked = false;
        bool topicButton3Clicked = false;
        bool topicButton4Clicked = false;

        private void topicButton1_Click(object sender, EventArgs e)
        {
            parent.AutoWriteSuggestedTopic(topicButton1.Text);
            topicButton1Clicked = true;
            topicButton2Clicked = false;
            topicButton3Clicked = false;
            topicButton4Clicked = false;
            topicButton1.FillColor = Color.LightBlue;
            topicButton2.FillColor = DefaultBackColor;
            topicButton3.FillColor = DefaultBackColor;
            topicButton4.FillColor = DefaultBackColor;
        }

        private void topicButton2_Click(object sender, EventArgs e)
        {
            parent.AutoWriteSuggestedTopic(topicButton2.Text);
            topicButton1Clicked = false;
            topicButton2Clicked = true;
            topicButton3Clicked = false;
            topicButton4Clicked = false;
            topicButton2.FillColor = Color.LightBlue;
            topicButton1.FillColor = DefaultBackColor;
            topicButton3.FillColor = DefaultBackColor;
            topicButton4.FillColor = DefaultBackColor;
        }

        private void topicButton3_Click(object sender, EventArgs e)
        {
            parent.AutoWriteSuggestedTopic(topicButton3.Text);
            topicButton1Clicked = false;
            topicButton2Clicked = false;
            topicButton3Clicked = true;
            topicButton4Clicked = false;
            topicButton3.FillColor = Color.LightBlue;
            topicButton1.FillColor = DefaultBackColor;
            topicButton2.FillColor = DefaultBackColor;
            topicButton4.FillColor = DefaultBackColor;
        }

        private void topicButton4_Click(object sender, EventArgs e)
        {
            parent.AutoWriteSuggestedTopic(topicButton4.Text);
            topicButton1Clicked = false;
            topicButton2Clicked = false;
            topicButton3Clicked = false;
            topicButton4Clicked = true;
            topicButton4.FillColor = Color.LightBlue;
            topicButton1.FillColor = DefaultBackColor;
            topicButton2.FillColor = DefaultBackColor;
            topicButton3.FillColor = DefaultBackColor;
        }
            
        
    }
}
