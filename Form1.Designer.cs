namespace UTSPBO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            lblwelcome = new Label();
            checkBox2 = new CheckBox();
            btnLanjut = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(265, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Dosen";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblwelcome
            // 
            lblwelcome.AutoSize = true;
            lblwelcome.Location = new Point(349, 57);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(64, 15);
            lblwelcome.TabIndex = 1;
            lblwelcome.Text = "WELCOME";
            lblwelcome.Click += label1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(415, 115);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(84, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Mahasiswa";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnLanjut
            // 
            btnLanjut.Location = new Point(344, 175);
            btnLanjut.Name = "btnLanjut";
            btnLanjut.Size = new Size(75, 23);
            btnLanjut.TabIndex = 3;
            btnLanjut.Text = "Lanjut";
            btnLanjut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLanjut);
            Controls.Add(checkBox2);
            Controls.Add(lblwelcome);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label lblwelcome;
        private CheckBox checkBox2;
        private Button btnLanjut;
    }
}
