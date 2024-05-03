namespace UTSPBO
{
    partial class LoginDosen
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
            lblLoginDosen = new Label();
            lblNoIdentitasDosenL = new Label();
            lblPWDosenL = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLoginDosen = new Button();
            LLLoginDosen = new LinkLabel();
            SuspendLayout();
            // 
            // lblLoginDosen
            // 
            lblLoginDosen.AutoSize = true;
            lblLoginDosen.Location = new Point(375, 51);
            lblLoginDosen.Name = "lblLoginDosen";
            lblLoginDosen.Size = new Size(110, 15);
            lblLoginDosen.TabIndex = 0;
            lblLoginDosen.Text = "Sudah punya akun?";
            // 
            // lblNoIdentitasDosenL
            // 
            lblNoIdentitasDosenL.AutoSize = true;
            lblNoIdentitasDosenL.Location = new Point(186, 110);
            lblNoIdentitasDosenL.Name = "lblNoIdentitasDosenL";
            lblNoIdentitasDosenL.Size = new Size(80, 15);
            lblNoIdentitasDosenL.TabIndex = 1;
            lblNoIdentitasDosenL.Text = "No. Identitas :";
            // 
            // lblPWDosenL
            // 
            lblPWDosenL.AutoSize = true;
            lblPWDosenL.Location = new Point(186, 153);
            lblPWDosenL.Name = "lblPWDosenL";
            lblPWDosenL.Size = new Size(66, 15);
            lblPWDosenL.TabIndex = 2;
            lblPWDosenL.Text = " Password :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 23);
            textBox2.TabIndex = 4;
            // 
            // btnLoginDosen
            // 
            btnLoginDosen.Location = new Point(394, 197);
            btnLoginDosen.Name = "btnLoginDosen";
            btnLoginDosen.Size = new Size(75, 23);
            btnLoginDosen.TabIndex = 5;
            btnLoginDosen.Text = "Login";
            btnLoginDosen.UseVisualStyleBackColor = true;
            // 
            // LLLoginDosen
            // 
            LLLoginDosen.AutoSize = true;
            LLLoginDosen.Location = new Point(379, 238);
            LLLoginDosen.Name = "LLLoginDosen";
            LLLoginDosen.Size = new Size(106, 15);
            LLLoginDosen.TabIndex = 6;
            LLLoginDosen.TabStop = true;
            LLLoginDosen.Text = "Belum punya akun";
            // 
            // LoginDosen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LLLoginDosen);
            Controls.Add(btnLoginDosen);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPWDosenL);
            Controls.Add(lblNoIdentitasDosenL);
            Controls.Add(lblLoginDosen);
            Name = "LoginDosen";
            Text = "LoginDosen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginDosen;
        private Label lblNoIdentitasDosenL;
        private Label lblPWDosenL;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLoginDosen;
        private LinkLabel LLLoginDosen;
    }
}