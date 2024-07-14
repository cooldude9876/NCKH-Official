namespace NCKH_Function
{
    partial class MCQSpace
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(500, 30);
            label1.TabIndex = 0;
            label1.Text = "Question :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 47);
            label2.Name = "label2";
            label2.Size = new Size(500, 17);
            label2.TabIndex = 1;
            label2.Text = "A. ...";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 75);
            label3.Name = "label3";
            label3.Size = new Size(500, 17);
            label3.TabIndex = 2;
            label3.Text = "B. ....";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 104);
            label4.Name = "label4";
            label4.Size = new Size(500, 17);
            label4.TabIndex = 3;
            label4.Text = "C. ....";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 133);
            label5.Name = "label5";
            label5.Size = new Size(500, 17);
            label5.TabIndex = 4;
            label5.Text = "D. ...";
            // 
            // MCQSpace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MCQSpace";
            Size = new Size(535, 160);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
