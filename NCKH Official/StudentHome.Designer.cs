namespace NCKH_Official
{
    partial class StudentHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 74);
            label1.Name = "label1";
            label1.Size = new Size(579, 60);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO <APP NAME>";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(112, 167);
            button1.Name = "button1";
            button1.Size = new Size(260, 98);
            button1.TabIndex = 2;
            button1.Text = "TẠO BÀI TẬP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(431, 167);
            button2.Name = "button2";
            button2.Size = new Size(260, 98);
            button2.TabIndex = 3;
            button2.Text = "TỪ ĐIỂN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(270, 296);
            button3.Name = "button3";
            button3.Size = new Size(260, 98);
            button3.TabIndex = 4;
            button3.Text = "LÀM BÀI VIẾT";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 73);
            label2.Name = "label2";
            label2.Size = new Size(579, 60);
            label2.TabIndex = 5;
            label2.Text = "WELCOME TO <APP NAME>";
            // 
            // StudentHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "StudentHome";
            Text = "StudentHome";
            Load += StudentHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}