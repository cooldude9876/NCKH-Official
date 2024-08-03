namespace NCKH_Official.UserControls
{
    partial class PassageSpace
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
            passageLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passageLabel
            // 
            passageLabel.AutoEllipsis = true;
            passageLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passageLabel.Location = new Point(0, 0);
            passageLabel.MaximumSize = new Size(402, 0);
            passageLabel.Name = "passageLabel";
            passageLabel.Size = new Size(402, 28);
            passageLabel.TabIndex = 0;
            passageLabel.Text = "Reading passage here....";
            // 
            // panel1
            // 
            panel1.Controls.Add(passageLabel);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 810);
            panel1.TabIndex = 1;
            // 
            // PassageSpace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel1);
            Name = "PassageSpace";
            Size = new Size(422, 830);
            Load += PassageSpace_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label passageLabel;
        private Panel panel1;
    }
}
