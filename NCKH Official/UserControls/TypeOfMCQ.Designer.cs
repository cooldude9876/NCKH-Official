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
            appropriateResponseCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            fITBCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            SuspendLayout();
            // 
            // appropriateResponseCheckBox
            // 
            appropriateResponseCheckBox.AutoSize = true;
            appropriateResponseCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            appropriateResponseCheckBox.CheckedState.BorderRadius = 0;
            appropriateResponseCheckBox.CheckedState.BorderThickness = 0;
            appropriateResponseCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            appropriateResponseCheckBox.CheckMarkColor = Color.Black;
            appropriateResponseCheckBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appropriateResponseCheckBox.Location = new Point(108, 69);
            appropriateResponseCheckBox.Name = "appropriateResponseCheckBox";
            appropriateResponseCheckBox.Size = new Size(295, 45);
            appropriateResponseCheckBox.TabIndex = 4;
            appropriateResponseCheckBox.Text = "Câu trả lời phù hợp";
            appropriateResponseCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            appropriateResponseCheckBox.UncheckedState.BorderRadius = 0;
            appropriateResponseCheckBox.UncheckedState.BorderThickness = 0;
            appropriateResponseCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            appropriateResponseCheckBox.CheckedChanged += findIncorrectBox_CheckedChanged;
            // 
            // fITBCheckBox
            // 
            fITBCheckBox.AutoSize = true;
            fITBCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            fITBCheckBox.CheckedState.BorderRadius = 0;
            fITBCheckBox.CheckedState.BorderThickness = 0;
            fITBCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            fITBCheckBox.CheckMarkColor = Color.Black;
            fITBCheckBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fITBCheckBox.Location = new Point(108, 0);
            fITBCheckBox.Name = "fITBCheckBox";
            fITBCheckBox.Size = new Size(294, 45);
            fITBCheckBox.TabIndex = 5;
            fITBCheckBox.Text = "Điền vào chỗ trống";
            fITBCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            fITBCheckBox.UncheckedState.BorderRadius = 0;
            fITBCheckBox.UncheckedState.BorderThickness = 0;
            fITBCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            fITBCheckBox.CheckedChanged += fITBBox_CheckedChanged;
            // 
            // TypeOfMCQ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(fITBCheckBox);
            Controls.Add(appropriateResponseCheckBox);
            Name = "TypeOfMCQ";
            Size = new Size(1110, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox appropriateResponseCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox fITBCheckBox;
    }
}
