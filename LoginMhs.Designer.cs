namespace UTSPBO
{
    partial class LoginMhs
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
            lblLoginMhs = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblNIMMhsL = new Label();
            lblPWMhsL = new Label();
            btnLoginMhs = new Button();
            LLLoginMhs = new LinkLabel();
            SuspendLayout();
            // 
            // lblLoginMhs
            // 
            lblLoginMhs.AutoSize = true;
            lblLoginMhs.Location = new Point(378, 45);
            lblLoginMhs.Name = "lblLoginMhs";
            lblLoginMhs.Size = new Size(110, 15);
            lblLoginMhs.TabIndex = 0;
            lblLoginMhs.Text = "Sudah punya akun?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(251, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 23);
            textBox2.TabIndex = 2;
            // 
            // lblNIMMhsL
            // 
            lblNIMMhsL.AutoSize = true;
            lblNIMMhsL.Location = new Point(182, 92);
            lblNIMMhsL.Name = "lblNIMMhsL";
            lblNIMMhsL.Size = new Size(36, 15);
            lblNIMMhsL.TabIndex = 3;
            lblNIMMhsL.Text = "NIM :";
            lblNIMMhsL.Click += label1_Click;
            // 
            // lblPWMhsL
            // 
            lblPWMhsL.AutoSize = true;
            lblPWMhsL.Location = new Point(182, 140);
            lblPWMhsL.Name = "lblPWMhsL";
            lblPWMhsL.Size = new Size(63, 15);
            lblPWMhsL.TabIndex = 4;
            lblPWMhsL.Text = "Password :";
            // 
            // btnLoginMhs
            // 
            btnLoginMhs.Location = new Point(398, 193);
            btnLoginMhs.Name = "btnLoginMhs";
            btnLoginMhs.Size = new Size(75, 23);
            btnLoginMhs.TabIndex = 5;
            btnLoginMhs.Text = "Login";
            btnLoginMhs.UseVisualStyleBackColor = true;
            // 
            // LLLoginMhs
            // 
            LLLoginMhs.AutoSize = true;
            LLLoginMhs.Location = new Point(382, 241);
            LLLoginMhs.Name = "LLLoginMhs";
            LLLoginMhs.Size = new Size(106, 15);
            LLLoginMhs.TabIndex = 6;
            LLLoginMhs.TabStop = true;
            LLLoginMhs.Text = "Belum punya akun";
            // 
            // LoginMhs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LLLoginMhs);
            Controls.Add(btnLoginMhs);
            Controls.Add(lblPWMhsL);
            Controls.Add(lblNIMMhsL);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblLoginMhs);
            Name = "LoginMhs";
            Text = "LoginMhs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginMhs;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblNIMMhsL;
        private Label lblPWMhsL;
        private Button btnLoginMhs;
        private LinkLabel LLLoginMhs;
    }
}