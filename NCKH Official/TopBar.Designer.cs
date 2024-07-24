namespace NCKH_Official
{
    partial class TopBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopBar));
            GenerateHWButton = new PictureBox();
            WritingButton = new PictureBox();
            DictionaryButton = new PictureBox();
            StudentHomeButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GenerateHWButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WritingButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DictionaryButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentHomeButton).BeginInit();
            SuspendLayout();
            // 
            // GenerateHWButton
            // 
            GenerateHWButton.Image = (Image)resources.GetObject("GenerateHWButton.Image");
            GenerateHWButton.Location = new Point(72, 3);
            GenerateHWButton.Name = "GenerateHWButton";
            GenerateHWButton.Size = new Size(38, 38);
            GenerateHWButton.SizeMode = PictureBoxSizeMode.StretchImage;
            GenerateHWButton.TabIndex = 3;
            GenerateHWButton.TabStop = false;
            GenerateHWButton.Click += pictureBox2_Click;
            // 
            // WritingButton
            // 
            WritingButton.Image = (Image)resources.GetObject("WritingButton.Image");
            WritingButton.Location = new Point(133, 3);
            WritingButton.Name = "WritingButton";
            WritingButton.Size = new Size(38, 38);
            WritingButton.SizeMode = PictureBoxSizeMode.StretchImage;
            WritingButton.TabIndex = 4;
            WritingButton.TabStop = false;
            WritingButton.Click += WritingButton_Click;
            // 
            // DictionaryButton
            // 
            DictionaryButton.Image = (Image)resources.GetObject("DictionaryButton.Image");
            DictionaryButton.Location = new Point(194, 3);
            DictionaryButton.Name = "DictionaryButton";
            DictionaryButton.Size = new Size(38, 38);
            DictionaryButton.SizeMode = PictureBoxSizeMode.StretchImage;
            DictionaryButton.TabIndex = 5;
            DictionaryButton.TabStop = false;
            DictionaryButton.Click += DictionaryButton_Click;
            // 
            // StudentHomeButton
            // 
            StudentHomeButton.Image = (Image)resources.GetObject("StudentHomeButton.Image");
            StudentHomeButton.Location = new Point(11, 1);
            StudentHomeButton.Name = "StudentHomeButton";
            StudentHomeButton.Size = new Size(42, 42);
            StudentHomeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            StudentHomeButton.TabIndex = 6;
            StudentHomeButton.TabStop = false;
            StudentHomeButton.Click += pictureBox1_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(StudentHomeButton);
            Controls.Add(DictionaryButton);
            Controls.Add(WritingButton);
            Controls.Add(GenerateHWButton);
            Name = "UserControl1";
            Size = new Size(800, 42);
            ((System.ComponentModel.ISupportInitialize)GenerateHWButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)WritingButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)DictionaryButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentHomeButton).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox GenerateHWButton;
        private PictureBox WritingButton;
        private PictureBox DictionaryButton;
        private PictureBox StudentHomeButton;
    }
}
