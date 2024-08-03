namespace NCKH_Official.UserControls
{
    partial class QuestionProgressButton
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            questionButton = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // questionButton
            // 
            questionButton.BorderRadius = 10;
            questionButton.BorderThickness = 1;
            questionButton.CustomizableEdges = customizableEdges1;
            questionButton.DisabledState.BorderColor = Color.DarkGray;
            questionButton.DisabledState.CustomBorderColor = Color.DarkGray;
            questionButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            questionButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            questionButton.FillColor = Color.White;
            questionButton.Font = new Font("Segoe UI", 9F);
            questionButton.ForeColor = Color.Black;
            questionButton.Location = new Point(0, 0);
            questionButton.Name = "questionButton";
            questionButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            questionButton.Size = new Size(55, 55);
            questionButton.TabIndex = 0;
            questionButton.Click += questionButton_Click;
            // 
            // QuestionProgressButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(questionButton);
            Name = "QuestionProgressButton";
            Size = new Size(55, 55);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button questionButton;
    }
}
