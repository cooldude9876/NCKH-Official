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
            wordFormationCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            rearrangeCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            SuspendLayout();
            // 
            // wordFormationCheckBox
            // 
            wordFormationCheckBox.AutoSize = true;
            wordFormationCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            wordFormationCheckBox.CheckedState.BorderRadius = 0;
            wordFormationCheckBox.CheckedState.BorderThickness = 0;
            wordFormationCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            wordFormationCheckBox.CheckMarkColor = Color.Black;
            wordFormationCheckBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wordFormationCheckBox.Location = new Point(108, 0);
            wordFormationCheckBox.Name = "wordFormationCheckBox";
            wordFormationCheckBox.Size = new Size(257, 45);
            wordFormationCheckBox.TabIndex = 0;
            wordFormationCheckBox.Text = "Word Formation";
            wordFormationCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            wordFormationCheckBox.UncheckedState.BorderRadius = 0;
            wordFormationCheckBox.UncheckedState.BorderThickness = 0;
            wordFormationCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // rearrangeCheckBox
            // 
            rearrangeCheckBox.AutoSize = true;
            rearrangeCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rearrangeCheckBox.CheckedState.BorderRadius = 0;
            rearrangeCheckBox.CheckedState.BorderThickness = 0;
            rearrangeCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rearrangeCheckBox.CheckMarkColor = Color.Black;
            rearrangeCheckBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rearrangeCheckBox.Location = new Point(108, 69);
            rearrangeCheckBox.Name = "rearrangeCheckBox";
            rearrangeCheckBox.Size = new Size(199, 45);
            rearrangeCheckBox.TabIndex = 1;
            rearrangeCheckBox.Text = "Sắp xếp câu";
            rearrangeCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rearrangeCheckBox.UncheckedState.BorderRadius = 0;
            rearrangeCheckBox.UncheckedState.BorderThickness = 0;
            rearrangeCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // TypeOfSAQ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(rearrangeCheckBox);
            Controls.Add(wordFormationCheckBox);
            Name = "TypeOfSAQ";
            Size = new Size(1110, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox wordFormationCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox rearrangeCheckBox;
    }
}
