namespace NCKH_Official
{
    partial class TypeOfSAQ
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
            wordFormationBox = new CheckBox();
            rearrangeBox = new CheckBox();
            sentenceRewriteBox = new CheckBox();
            numberOfWordFormation = new NumericUpDown();
            numberOfRearrange = new NumericUpDown();
            numberOfSentenceRewrite = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numberOfWordFormation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfRearrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfSentenceRewrite).BeginInit();
            SuspendLayout();
            // 
            // wordFormationBox
            // 
            wordFormationBox.AutoSize = true;
            wordFormationBox.Location = new Point(0, 1);
            wordFormationBox.Name = "wordFormationBox";
            wordFormationBox.Size = new Size(137, 24);
            wordFormationBox.TabIndex = 0;
            wordFormationBox.Text = "Word formation";
            wordFormationBox.UseVisualStyleBackColor = true;
            wordFormationBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // rearrangeBox
            // 
            rearrangeBox.AutoSize = true;
            rearrangeBox.Location = new Point(0, 38);
            rearrangeBox.Name = "rearrangeBox";
            rearrangeBox.Size = new Size(131, 24);
            rearrangeBox.TabIndex = 1;
            rearrangeBox.Text = "Sắp xếp lại câu";
            rearrangeBox.UseVisualStyleBackColor = true;
            rearrangeBox.CheckedChanged += rearrangeBox_CheckedChanged;
            // 
            // sentenceRewriteBox
            // 
            sentenceRewriteBox.AutoSize = true;
            sentenceRewriteBox.Location = new Point(0, 75);
            sentenceRewriteBox.Name = "sentenceRewriteBox";
            sentenceRewriteBox.Size = new Size(104, 24);
            sentenceRewriteBox.TabIndex = 2;
            sentenceRewriteBox.Text = "Viết lại câu";
            sentenceRewriteBox.UseVisualStyleBackColor = true;
            sentenceRewriteBox.CheckedChanged += sentenceRewriteBox_CheckedChanged;
            // 
            // numberOfWordFormation
            // 
            numberOfWordFormation.Location = new Point(164, 0);
            numberOfWordFormation.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numberOfWordFormation.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfWordFormation.Name = "numberOfWordFormation";
            numberOfWordFormation.Size = new Size(44, 27);
            numberOfWordFormation.TabIndex = 3;
            numberOfWordFormation.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfWordFormation.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numberOfRearrange
            // 
            numberOfRearrange.Location = new Point(164, 37);
            numberOfRearrange.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numberOfRearrange.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfRearrange.Name = "numberOfRearrange";
            numberOfRearrange.Size = new Size(44, 27);
            numberOfRearrange.TabIndex = 4;
            numberOfRearrange.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfRearrange.ValueChanged += numberOfRearrange_ValueChanged;
            // 
            // numberOfSentenceRewrite
            // 
            numberOfSentenceRewrite.Location = new Point(164, 72);
            numberOfSentenceRewrite.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numberOfSentenceRewrite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfSentenceRewrite.Name = "numberOfSentenceRewrite";
            numberOfSentenceRewrite.Size = new Size(44, 27);
            numberOfSentenceRewrite.TabIndex = 5;
            numberOfSentenceRewrite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numberOfSentenceRewrite.ValueChanged += numberOfSentenceRewrite_ValueChanged;
            // 
            // TypeOfSAQ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numberOfSentenceRewrite);
            Controls.Add(numberOfRearrange);
            Controls.Add(numberOfWordFormation);
            Controls.Add(sentenceRewriteBox);
            Controls.Add(rearrangeBox);
            Controls.Add(wordFormationBox);
            Name = "TypeOfSAQ";
            Size = new Size(206, 100);
            ((System.ComponentModel.ISupportInitialize)numberOfWordFormation).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfRearrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfSentenceRewrite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox wordFormationBox;
        private CheckBox rearrangeBox;
        private CheckBox sentenceRewriteBox;
        private NumericUpDown numberOfWordFormation;
        private NumericUpDown numberOfRearrange;
        private NumericUpDown numberOfSentenceRewrite;
    }
}
