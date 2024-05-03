namespace UTSPBO
{
    partial class RegisterDosen
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
            lblRegisDosen = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            lblNamaDosenR = new Label();
            lblEmailDosenR = new Label();
            lblNoIdentitasR = new Label();
            lblNoHPDosenR = new Label();
            lblPWDosenR = new Label();
            btnRegisDosen = new Button();
            LLRegisDosen = new LinkLabel();
            SuspendLayout();
            // 
            // lblRegisDosen
            // 
            lblRegisDosen.AutoSize = true;
            lblRegisDosen.Location = new Point(381, 35);
            lblRegisDosen.Name = "lblRegisDosen";
            lblRegisDosen.Size = new Size(110, 15);
            lblRegisDosen.TabIndex = 0;
            lblRegisDosen.Text = "Sudah punya akun?";
            lblRegisDosen.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(246, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(399, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(246, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(399, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(246, 154);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(399, 23);
            textBox5.TabIndex = 5;
            // 
            // lblNamaDosenR
            // 
            lblNamaDosenR.AutoSize = true;
            lblNamaDosenR.Location = new Point(159, 70);
            lblNamaDosenR.Name = "lblNamaDosenR";
            lblNamaDosenR.Size = new Size(45, 15);
            lblNamaDosenR.TabIndex = 6;
            lblNamaDosenR.Text = "Nama :";
            // 
            // lblEmailDosenR
            // 
            lblEmailDosenR.AutoSize = true;
            lblEmailDosenR.Location = new Point(160, 99);
            lblEmailDosenR.Name = "lblEmailDosenR";
            lblEmailDosenR.Size = new Size(42, 15);
            lblEmailDosenR.TabIndex = 7;
            lblEmailDosenR.Text = "Email :";
            // 
            // lblNoIdentitasR
            // 
            lblNoIdentitasR.AutoSize = true;
            lblNoIdentitasR.Location = new Point(160, 130);
            lblNoIdentitasR.Name = "lblNoIdentitasR";
            lblNoIdentitasR.Size = new Size(80, 15);
            lblNoIdentitasR.TabIndex = 8;
            lblNoIdentitasR.Text = "No. Identitas :";
            // 
            // lblNoHPDosenR
            // 
            lblNoHPDosenR.AutoSize = true;
            lblNoHPDosenR.Location = new Point(160, 157);
            lblNoHPDosenR.Name = "lblNoHPDosenR";
            lblNoHPDosenR.Size = new Size(51, 15);
            lblNoHPDosenR.TabIndex = 9;
            lblNoHPDosenR.Text = "No. HP :";
            // 
            // lblPWDosenR
            // 
            lblPWDosenR.AutoSize = true;
            lblPWDosenR.Location = new Point(160, 187);
            lblPWDosenR.Name = "lblPWDosenR";
            lblPWDosenR.Size = new Size(63, 15);
            lblPWDosenR.TabIndex = 10;
            lblPWDosenR.Text = "Password :";
            // 
            // btnRegisDosen
            // 
            btnRegisDosen.Location = new Point(409, 223);
            btnRegisDosen.Name = "btnRegisDosen";
            btnRegisDosen.Size = new Size(75, 23);
            btnRegisDosen.TabIndex = 11;
            btnRegisDosen.Text = "Register";
            btnRegisDosen.UseVisualStyleBackColor = true;
            // 
            // LLRegisDosen
            // 
            LLRegisDosen.AutoSize = true;
            LLRegisDosen.Location = new Point(395, 266);
            LLRegisDosen.Name = "LLRegisDosen";
            LLRegisDosen.Size = new Size(105, 15);
            LLRegisDosen.TabIndex = 12;
            LLRegisDosen.TabStop = true;
            LLRegisDosen.Text = "Sudah punya akun";
            // 
            // RegisterDosen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LLRegisDosen);
            Controls.Add(btnRegisDosen);
            Controls.Add(lblPWDosenR);
            Controls.Add(lblNoHPDosenR);
            Controls.Add(lblNoIdentitasR);
            Controls.Add(lblEmailDosenR);
            Controls.Add(lblNamaDosenR);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblRegisDosen);
            Name = "RegisterDosen";
            Text = "RegisterDosen";
            Load += RegisterDosen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegisDosen;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label lblNamaDosenR;
        private Label lblEmailDosenR;
        private Label lblNoIdentitasR;
        private Label lblNoHPDosenR;
        private Label lblPWDosenR;
        private Button btnRegisDosen;
        private LinkLabel LLRegisDosen;
    }
}