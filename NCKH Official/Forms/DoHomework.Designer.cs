namespace NCKH_Official
{
    partial class DoHomework
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            progressPanel = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            showQuestionPanel = new Panel();
            panel1 = new Panel();
            submitButton = new Guna.UI2.WinForms.Guna2Button();
            progressPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // progressPanel
            // 
            progressPanel.BorderStyle = BorderStyle.FixedSingle;
            progressPanel.Controls.Add(label1);
            progressPanel.Location = new Point(0, 75);
            progressPanel.Name = "progressPanel";
            progressPanel.Size = new Size(400, 906);
            progressPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 30);
            label1.Name = "label1";
            label1.Size = new Size(187, 54);
            label1.TabIndex = 1;
            label1.Text = "Tiến độ : ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(showQuestionPanel);
            panel2.Location = new Point(400, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(1524, 980);
            panel2.TabIndex = 1;
            // 
            // showQuestionPanel
            // 
            showQuestionPanel.BackColor = SystemColors.ControlLightLight;
            showQuestionPanel.BorderStyle = BorderStyle.FixedSingle;
            showQuestionPanel.Location = new Point(75, 75);
            showQuestionPanel.Margin = new Padding(0);
            showQuestionPanel.Name = "showQuestionPanel";
            showQuestionPanel.Size = new Size(1374, 830);
            showQuestionPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(submitButton);
            panel1.Location = new Point(0, 981);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 74);
            panel1.TabIndex = 2;
            // 
            // submitButton
            // 
            submitButton.BorderRadius = 10;
            submitButton.BorderThickness = 1;
            submitButton.CustomizableEdges = customizableEdges1;
            submitButton.DisabledState.BorderColor = Color.DarkGray;
            submitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            submitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            submitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            submitButton.FillColor = Color.LightSkyBlue;
            submitButton.Font = new Font("Segoe UI", 9F);
            submitButton.ForeColor = Color.Black;
            submitButton.Location = new Point(130, 13);
            submitButton.Name = "submitButton";
            submitButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            submitButton.Size = new Size(140, 48);
            submitButton.TabIndex = 0;
            submitButton.Text = "Nộp bài";
            // 
            // DoHomework
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(progressPanel);
            Name = "DoHomework";
            Text = "DoHomework";
            WindowState = FormWindowState.Maximized;
            Load += DoHomework_Load;
            progressPanel.ResumeLayout(false);
            progressPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel progressPanel;
        private Panel panel2;
        private Label label1;
        private Panel showQuestionPanel;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button submitButton;
    }
}