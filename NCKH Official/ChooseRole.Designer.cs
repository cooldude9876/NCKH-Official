namespace NCKH_Official
{
    partial class ChooseRole
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentButton = new Button();
            teacherButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // studentButton
            // 
            studentButton.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentButton.Location = new Point(74, 149);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(255, 209);
            studentButton.TabIndex = 0;
            studentButton.Text = "Học sinh";
            studentButton.UseVisualStyleBackColor = true;
            studentButton.Click += studentButton_Click;
            // 
            // teacherButton
            // 
            teacherButton.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacherButton.Location = new Point(473, 149);
            teacherButton.Name = "teacherButton";
            teacherButton.Size = new Size(255, 209);
            teacherButton.TabIndex = 1;
            teacherButton.Text = "Giáo viên";
            teacherButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 37);
            label1.Name = "label1";
            label1.Size = new Size(194, 52);
            label1.TabIndex = 2;
            label1.Text = "Bạn là ai ?";
            // 
            // ChooseRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(teacherButton);
            Controls.Add(studentButton);
            Name = "ChooseRole";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button studentButton;
        private Button teacherButton;
        private Label label1;
    }
}
