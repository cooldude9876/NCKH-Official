namespace NCKH_Official.Forms
{
    partial class QuestionProgress
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
            label1 = new Label();
            buttonPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 41);
            label1.TabIndex = 0;
            label1.Text = "<Type> :";
            // 
            // buttonPanel
            // 
            buttonPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonPanel.Location = new Point(24, 54);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(352, 198);
            buttonPanel.TabIndex = 1;
            // 
            // QuestionProgress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(buttonPanel);
            Controls.Add(label1);
            MinimumSize = new Size(400, 0);
            Name = "QuestionProgress";
            Size = new Size(400, 271);
            Load += MCProgress_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel buttonPanel;
    }
}
