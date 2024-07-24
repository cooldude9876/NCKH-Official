namespace NCKH_Official
{
    partial class TypeOfMCQ
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
            fillInTheBlankBox = new CheckBox();
            pronunciationBox = new CheckBox();
            stressSyllableBox = new CheckBox();
            numberOfFITB = new NumericUpDown();
            numberOfPronunciation = new NumericUpDown();
            numberOfStressSyllable = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numberOfFITB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfPronunciation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfStressSyllable).BeginInit();
            SuspendLayout();
            // 
            // fillInTheBlankBox
            // 
            fillInTheBlankBox.AutoSize = true;
            fillInTheBlankBox.Location = new Point(0, 1);
            fillInTheBlankBox.Name = "fillInTheBlankBox";
            fillInTheBlankBox.Size = new Size(158, 24);
            fillInTheBlankBox.TabIndex = 0;
            fillInTheBlankBox.Text = "Điền vào chỗ trống";
            fillInTheBlankBox.UseVisualStyleBackColor = true;
            fillInTheBlankBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pronunciationBox
            // 
            pronunciationBox.AutoSize = true;
            pronunciationBox.Location = new Point(0, 38);
            pronunciationBox.Name = "pronunciationBox";
            pronunciationBox.Size = new Size(85, 24);
            pronunciationBox.TabIndex = 1;
            pronunciationBox.Text = "Phát âm";
            pronunciationBox.UseVisualStyleBackColor = true;
            pronunciationBox.CheckedChanged += pronunciationBox_CheckedChanged;
            // 
            // stressSyllableBox
            // 
            stressSyllableBox.AutoSize = true;
            stressSyllableBox.Location = new Point(0, 75);
            stressSyllableBox.Name = "stressSyllableBox";
            stressSyllableBox.Size = new Size(91, 24);
            stressSyllableBox.TabIndex = 2;
            stressSyllableBox.Text = "Nhấn âm";
            stressSyllableBox.UseVisualStyleBackColor = true;
            stressSyllableBox.CheckedChanged += stressSyllableBox_CheckedChanged;
            // 
            // numberOfFITB
            // 
            numberOfFITB.Location = new Point(164, 0);
            numberOfFITB.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numberOfFITB.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfFITB.Name = "numberOfFITB";
            numberOfFITB.Size = new Size(44, 27);
            numberOfFITB.TabIndex = 3;
            numberOfFITB.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfFITB.ValueChanged += numberOfFITB_ValueChanged;
            // 
            // numberOfPronunciation
            // 
            numberOfPronunciation.Location = new Point(164, 37);
            numberOfPronunciation.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numberOfPronunciation.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfPronunciation.Name = "numberOfPronunciation";
            numberOfPronunciation.Size = new Size(44, 27);
            numberOfPronunciation.TabIndex = 4;
            numberOfPronunciation.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfPronunciation.ValueChanged += numberOfPronunciation_ValueChanged;
            // 
            // numberOfStressSyllable
            // 
            numberOfStressSyllable.Location = new Point(164, 72);
            numberOfStressSyllable.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numberOfStressSyllable.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfStressSyllable.Name = "numberOfStressSyllable";
            numberOfStressSyllable.Size = new Size(44, 27);
            numberOfStressSyllable.TabIndex = 5;
            numberOfStressSyllable.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfStressSyllable.ValueChanged += numberOfStressSyllable_ValueChanged;
            // 
            // TypeOfMCQ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numberOfStressSyllable);
            Controls.Add(numberOfPronunciation);
            Controls.Add(numberOfFITB);
            Controls.Add(stressSyllableBox);
            Controls.Add(pronunciationBox);
            Controls.Add(fillInTheBlankBox);
            Name = "TypeOfMCQ";
            Size = new Size(206, 100);
            ((System.ComponentModel.ISupportInitialize)numberOfFITB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfPronunciation).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfStressSyllable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox fillInTheBlankBox;
        private CheckBox pronunciationBox;
        private CheckBox stressSyllableBox;
        private NumericUpDown numberOfFITB;
        private NumericUpDown numberOfPronunciation;
        private NumericUpDown numberOfStressSyllable;
    }
}
