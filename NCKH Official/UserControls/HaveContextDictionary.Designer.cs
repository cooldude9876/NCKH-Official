namespace NCKH_Official
{
    partial class HaveContextDictionary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            wordLabel = new Label();
            partOfSpeechLabel = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            meaningLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // wordLabel
            // 
            wordLabel.AutoSize = true;
            wordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wordLabel.Location = new Point(15, 8);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(91, 41);
            wordLabel.TabIndex = 0;
            wordLabel.Text = "Word";
            // 
            // partOfSpeechLabel
            // 
            partOfSpeechLabel.AutoSize = true;
            partOfSpeechLabel.Font = new Font("Segoe UI", 9F);
            partOfSpeechLabel.Location = new Point(15, 53);
            partOfSpeechLabel.Name = "partOfSpeechLabel";
            partOfSpeechLabel.Size = new Size(112, 20);
            partOfSpeechLabel.TabIndex = 1;
            partOfSpeechLabel.Text = "[Part of speech]";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Black;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(15, 120);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(505, 1);
            guna2Button1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(15, 85);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 3;
            label1.Text = "UK :  / /  US : / /";
            // 
            // meaningLabel
            // 
            meaningLabel.AutoSize = true;
            meaningLabel.Location = new Point(15, 134);
            meaningLabel.Name = "meaningLabel";
            meaningLabel.Size = new Size(67, 20);
            meaningLabel.TabIndex = 4;
            meaningLabel.Text = "Meaning";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 163);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 5;
            label2.Text = "Example";
            // 
            // HaveContextDictionary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(meaningLabel);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(partOfSpeechLabel);
            Controls.Add(wordLabel);
            Name = "HaveContextDictionary";
            Size = new Size(535, 292);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label wordLabel;
        private Label partOfSpeechLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
        private Label meaningLabel;
        private Label label2;
    }
}
