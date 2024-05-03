namespace UTSPBO
{
    partial class RegisterMhs
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            lblRegisMhs = new Label();
            lblNamaMhsR = new Label();
            lblNIMMhsR = new Label();
            lblEmailMhsR = new Label();
            lblNoHPMhsR = new Label();
            lblPWMhsR = new Label();
            btnRegisMhs = new Button();
            LLRegisMhs = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(390, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(247, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(390, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(247, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(390, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(247, 195);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(390, 23);
            textBox5.TabIndex = 4;
            // 
            // lblRegisMhs
            // 
            lblRegisMhs.AutoSize = true;
            lblRegisMhs.Location = new Point(373, 38);
            lblRegisMhs.Name = "lblRegisMhs";
            lblRegisMhs.Size = new Size(111, 15);
            lblRegisMhs.TabIndex = 5;
            lblRegisMhs.Text = "Belum punya akun?";
            // 
            // lblNamaMhsR
            // 
            lblNamaMhsR.AutoSize = true;
            lblNamaMhsR.Location = new Point(175, 82);
            lblNamaMhsR.Name = "lblNamaMhsR";
            lblNamaMhsR.Size = new Size(45, 15);
            lblNamaMhsR.TabIndex = 6;
            lblNamaMhsR.Text = "Nama :";
            lblNamaMhsR.Click += lblNamaMhsR_Click;
            // 
            // lblNIMMhsR
            // 
            lblNIMMhsR.AutoSize = true;
            lblNIMMhsR.Location = new Point(175, 111);
            lblNIMMhsR.Name = "lblNIMMhsR";
            lblNIMMhsR.Size = new Size(36, 15);
            lblNIMMhsR.TabIndex = 7;
            lblNIMMhsR.Text = "NIM :";
            // 
            // lblEmailMhsR
            // 
            lblEmailMhsR.AutoSize = true;
            lblEmailMhsR.Location = new Point(175, 140);
            lblEmailMhsR.Name = "lblEmailMhsR";
            lblEmailMhsR.Size = new Size(45, 15);
            lblEmailMhsR.TabIndex = 8;
            lblEmailMhsR.Text = " Email :";
            // 
            // lblNoHPMhsR
            // 
            lblNoHPMhsR.AutoSize = true;
            lblNoHPMhsR.Location = new Point(175, 169);
            lblNoHPMhsR.Name = "lblNoHPMhsR";
            lblNoHPMhsR.Size = new Size(51, 15);
            lblNoHPMhsR.TabIndex = 9;
            lblNoHPMhsR.Text = "No. HP :";
            // 
            // lblPWMhsR
            // 
            lblPWMhsR.AutoSize = true;
            lblPWMhsR.Location = new Point(175, 198);
            lblPWMhsR.Name = "lblPWMhsR";
            lblPWMhsR.Size = new Size(63, 15);
            lblPWMhsR.TabIndex = 10;
            lblPWMhsR.Text = "Password :";
            // 
            // btnRegisMhs
            // 
            btnRegisMhs.Location = new Point(400, 240);
            btnRegisMhs.Name = "btnRegisMhs";
            btnRegisMhs.Size = new Size(75, 23);
            btnRegisMhs.TabIndex = 11;
            btnRegisMhs.Text = "Register";
            btnRegisMhs.UseVisualStyleBackColor = true;
            // 
            // LLRegisMhs
            // 
            LLRegisMhs.AutoSize = true;
            LLRegisMhs.Location = new Point(389, 277);
            LLRegisMhs.Name = "LLRegisMhs";
            LLRegisMhs.Size = new Size(105, 15);
            LLRegisMhs.TabIndex = 12;
            LLRegisMhs.TabStop = true;
            LLRegisMhs.Text = "Sudah punya akun";
            // 
            // RegisterMhs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LLRegisMhs);
            Controls.Add(btnRegisMhs);
            Controls.Add(lblPWMhsR);
            Controls.Add(lblNoHPMhsR);
            Controls.Add(lblEmailMhsR);
            Controls.Add(lblNIMMhsR);
            Controls.Add(lblNamaMhsR);
            Controls.Add(lblRegisMhs);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "RegisterMhs";
            Text = "RegisterMhs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label lblRegisMhs;
        private Label lblNamaMhsR;
        private Label lblNIMMhsR;
        private Label lblEmailMhsR;
        private Label lblNoHPMhsR;
        private Label lblPWMhsR;
        private Button btnRegisMhs;
        private LinkLabel LLRegisMhs;
    }
}