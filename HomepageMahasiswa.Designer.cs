namespace UTSPBO
{
    partial class HomepageMahasiswa
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
            lblHpgMhs = new Label();
            lblHpgNamaMhs = new Label();
            lblNIMHpgMhs = new Label();
            lblEmailHpgMhs = new Label();
            lblNoHPHpgMhs = new Label();
            lblProdiHpgMhs = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // lblHpgMhs
            // 
            lblHpgMhs.AutoSize = true;
            lblHpgMhs.Location = new Point(345, 22);
            lblHpgMhs.Name = "lblHpgMhs";
            lblHpgMhs.Size = new Size(124, 15);
            lblHpgMhs.TabIndex = 0;
            lblHpgMhs.Text = "Halo, Selamat Datang!";
            // 
            // lblHpgNamaMhs
            // 
            lblHpgNamaMhs.AutoSize = true;
            lblHpgNamaMhs.Location = new Point(210, 72);
            lblHpgNamaMhs.Name = "lblHpgNamaMhs";
            lblHpgNamaMhs.Size = new Size(45, 15);
            lblHpgNamaMhs.TabIndex = 1;
            lblHpgNamaMhs.Text = "Nama :";
            // 
            // lblNIMHpgMhs
            // 
            lblNIMHpgMhs.AutoSize = true;
            lblNIMHpgMhs.Location = new Point(210, 101);
            lblNIMHpgMhs.Name = "lblNIMHpgMhs";
            lblNIMHpgMhs.Size = new Size(36, 15);
            lblNIMHpgMhs.TabIndex = 2;
            lblNIMHpgMhs.Text = "NIM :";
            lblNIMHpgMhs.Click += label2_Click;
            // 
            // lblEmailHpgMhs
            // 
            lblEmailHpgMhs.AutoSize = true;
            lblEmailHpgMhs.Location = new Point(210, 132);
            lblEmailHpgMhs.Name = "lblEmailHpgMhs";
            lblEmailHpgMhs.Size = new Size(45, 15);
            lblEmailHpgMhs.TabIndex = 3;
            lblEmailHpgMhs.Text = "Email : ";
            // 
            // lblNoHPHpgMhs
            // 
            lblNoHPHpgMhs.AutoSize = true;
            lblNoHPHpgMhs.Location = new Point(210, 164);
            lblNoHPHpgMhs.Name = "lblNoHPHpgMhs";
            lblNoHPHpgMhs.Size = new Size(51, 15);
            lblNoHPHpgMhs.TabIndex = 4;
            lblNoHPHpgMhs.Text = "No. HP :";
            // 
            // lblProdiHpgMhs
            // 
            lblProdiHpgMhs.AutoSize = true;
            lblProdiHpgMhs.Location = new Point(214, 194);
            lblProdiHpgMhs.Name = "lblProdiHpgMhs";
            lblProdiHpgMhs.Size = new Size(41, 15);
            lblProdiHpgMhs.TabIndex = 5;
            lblProdiHpgMhs.Text = "Prodi :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(276, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(383, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(276, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(383, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(276, 156);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(383, 23);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // HomepageMahasiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblProdiHpgMhs);
            Controls.Add(lblNoHPHpgMhs);
            Controls.Add(lblEmailHpgMhs);
            Controls.Add(lblNIMHpgMhs);
            Controls.Add(lblHpgNamaMhs);
            Controls.Add(lblHpgMhs);
            Name = "HomepageMahasiswa";
            Text = "HomepageMahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHpgMhs;
        private Label lblHpgNamaMhs;
        private Label lblNIMHpgMhs;
        private Label lblEmailHpgMhs;
        private Label lblNoHPHpgMhs;
        private Label lblProdiHpgMhs;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}