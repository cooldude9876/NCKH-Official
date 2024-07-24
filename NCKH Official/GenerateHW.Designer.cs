namespace NCKH_Official
{
    partial class GenerateHW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            CustomPanel = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            ReadingBox = new CheckBox();
            ShortAnswerBox = new CheckBox();
            MultipleChoiceBox = new CheckBox();
            topicComboBox = new ComboBox();
            label5 = new Label();
            levelUpDown = new NumericUpDown();
            label4 = new Label();
            panel6 = new Panel();
            panel4 = new Panel();
            generateButton = new Button();
            label6 = new Label();
            panel7 = new Panel();
            button2 = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            CustomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)levelUpDown).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 42);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 5);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 3;
            label1.Text = "  Tùy chỉnh bài tập  ";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(265, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(535, 42);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 5);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 4;
            label2.Text = "<Tên bài tập>";
            // 
            // CustomPanel
            // 
            CustomPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomPanel.AutoScroll = true;
            CustomPanel.BorderStyle = BorderStyle.FixedSingle;
            CustomPanel.Controls.Add(label9);
            CustomPanel.Controls.Add(label8);
            CustomPanel.Controls.Add(label7);
            CustomPanel.Controls.Add(label3);
            CustomPanel.Controls.Add(ReadingBox);
            CustomPanel.Controls.Add(ShortAnswerBox);
            CustomPanel.Controls.Add(MultipleChoiceBox);
            CustomPanel.Controls.Add(topicComboBox);
            CustomPanel.Controls.Add(label5);
            CustomPanel.Controls.Add(levelUpDown);
            CustomPanel.Controls.Add(label4);
            CustomPanel.Location = new Point(0, 84);
            CustomPanel.Name = "CustomPanel";
            CustomPanel.Size = new Size(265, 325);
            CustomPanel.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(155, 185);
            label9.Name = "label9";
            label9.Size = new Size(66, 28);
            label9.TabIndex = 16;
            label9.Text = "Tổng :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(155, 142);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 15;
            label8.Text = "Tổng :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(155, 139);
            label7.Name = "label7";
            label7.Size = new Size(0, 23);
            label7.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(155, 96);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 13;
            label3.Text = "Tổng :";
            label3.Click += label3_Click;
            // 
            // ReadingBox
            // 
            ReadingBox.AutoSize = true;
            ReadingBox.Font = new Font("Segoe UI", 12F);
            ReadingBox.Location = new Point(5, 181);
            ReadingBox.Name = "ReadingBox";
            ReadingBox.Size = new Size(124, 32);
            ReadingBox.TabIndex = 12;
            ReadingBox.Text = "Đọc - hiểu";
            ReadingBox.UseVisualStyleBackColor = true;
            // 
            // ShortAnswerBox
            // 
            ShortAnswerBox.AutoSize = true;
            ShortAnswerBox.Font = new Font("Segoe UI", 12F);
            ShortAnswerBox.Location = new Point(5, 138);
            ShortAnswerBox.Name = "ShortAnswerBox";
            ShortAnswerBox.Size = new Size(135, 32);
            ShortAnswerBox.TabIndex = 11;
            ShortAnswerBox.Text = "Trả lời ngắn";
            ShortAnswerBox.UseVisualStyleBackColor = true;
            ShortAnswerBox.CheckedChanged += ShortAnswerBox_CheckedChanged;
            // 
            // MultipleChoiceBox
            // 
            MultipleChoiceBox.AutoSize = true;
            MultipleChoiceBox.Font = new Font("Segoe UI", 12F);
            MultipleChoiceBox.Location = new Point(5, 95);
            MultipleChoiceBox.Name = "MultipleChoiceBox";
            MultipleChoiceBox.Size = new Size(139, 32);
            MultipleChoiceBox.TabIndex = 10;
            MultipleChoiceBox.Text = "Trắc nghiệm";
            MultipleChoiceBox.UseVisualStyleBackColor = true;
            MultipleChoiceBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // topicComboBox
            // 
            topicComboBox.FormattingEnabled = true;
            topicComboBox.Location = new Point(83, 56);
            topicComboBox.Name = "topicComboBox";
            topicComboBox.Size = new Size(151, 28);
            topicComboBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 52);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 8;
            label5.Text = "Chủ đề :";
            // 
            // levelUpDown
            // 
            levelUpDown.Location = new Point(91, 14);
            levelUpDown.Name = "levelUpDown";
            levelUpDown.Size = new Size(49, 27);
            levelUpDown.TabIndex = 7;
            levelUpDown.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 6;
            label4.Text = "Độ khó :";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.AutoScroll = true;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(265, 84);
            panel6.Name = "panel6";
            panel6.Size = new Size(535, 325);
            panel6.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(generateButton);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(265, 42);
            panel4.TabIndex = 4;
            // 
            // generateButton
            // 
            generateButton.BackColor = SystemColors.GradientInactiveCaption;
            generateButton.Location = new Point(170, 6);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(75, 30);
            generateButton.TabIndex = 1;
            generateButton.Text = "Tạo bài";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 0;
            label6.Text = "Tổng số câu :";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(button2);
            panel7.Location = new Point(265, 408);
            panel7.Name = "panel7";
            panel7.Size = new Size(535, 42);
            panel7.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Location = new Point(220, 6);
            button2.Name = "button2";
            button2.Size = new Size(95, 30);
            button2.TabIndex = 0;
            button2.Text = "Làm bài";
            button2.UseVisualStyleBackColor = false;
            // 
            // GenerateHW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel6);
            Controls.Add(CustomPanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "GenerateHW";
            Text = "GenerateHW";
            Load += GenerateHW_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            CustomPanel.ResumeLayout(false);
            CustomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)levelUpDown).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Panel CustomPanel;
        private Panel panel6;
        private Label label4;
        private NumericUpDown levelUpDown;
        private Label label5;
        private CheckBox ReadingBox;
        private CheckBox ShortAnswerBox;
        private CheckBox MultipleChoiceBox;
        private ComboBox topicComboBox;
        private Panel panel4;
        private Button generateButton;
        private Label label6;
        private Panel panel7;
        private Button button2;
        private Label label3;
        private Label label7;
        private Label label9;
        private Label label8;
    }
}