namespace NCKH_Official
{
    partial class TypeOfRQ
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
            mainIdeaCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            trueFalseCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            SuspendLayout();
            // 
            // mainIdeaCheckBox
            // 
            mainIdeaCheckBox.AutoSize = true;
            mainIdeaCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            mainIdeaCheckBox.CheckedState.BorderRadius = 0;
            mainIdeaCheckBox.CheckedState.BorderThickness = 0;
            mainIdeaCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            mainIdeaCheckBox.CheckMarkColor = Color.Black;
            mainIdeaCheckBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mainIdeaCheckBox.Location = new Point(108, 0);
            mainIdeaCheckBox.Name = "mainIdeaCheckBox";
            mainIdeaCheckBox.Size = new Size(297, 45);
            mainIdeaCheckBox.TabIndex = 0;
            mainIdeaCheckBox.Text = "Tìm nội dung chính";
            mainIdeaCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            mainIdeaCheckBox.UncheckedState.BorderRadius = 0;
            mainIdeaCheckBox.UncheckedState.BorderThickness = 0;
            mainIdeaCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // trueFalseCheckBox
            // 
            trueFalseCheckBox.AutoSize = true;
            trueFalseCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            trueFalseCheckBox.CheckedState.BorderRadius = 0;
            trueFalseCheckBox.CheckedState.BorderThickness = 0;
            trueFalseCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            trueFalseCheckBox.CheckMarkColor = Color.Black;
            trueFalseCheckBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trueFalseCheckBox.Location = new Point(108, 69);
            trueFalseCheckBox.Name = "trueFalseCheckBox";
            trueFalseCheckBox.Size = new Size(189, 45);
            trueFalseCheckBox.TabIndex = 1;
            trueFalseCheckBox.Text = "True / False";
            trueFalseCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            trueFalseCheckBox.UncheckedState.BorderRadius = 0;
            trueFalseCheckBox.UncheckedState.BorderThickness = 0;
            trueFalseCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // TypeOfRQ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(trueFalseCheckBox);
            Controls.Add(mainIdeaCheckBox);
            Name = "TypeOfRQ";
            Size = new Size(1110, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CheckBox mainIdeaCheckBox;
        private Guna.UI2.WinForms.Guna2CheckBox trueFalseCheckBox;
    }
}
