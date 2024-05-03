namespace UTSPBO
{
    partial class HomepageDosen
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
            lblHpgDosen = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbljmlMhs = new Label();
            SuspendLayout();
            // 
            // lblHpgDosen
            // 
            lblHpgDosen.AutoSize = true;
            lblHpgDosen.Location = new Point(306, 50);
            lblHpgDosen.Name = "lblHpgDosen";
            lblHpgDosen.Size = new Size(188, 15);
            lblHpgDosen.TabIndex = 0;
            lblHpgDosen.Text = "Halo! Berikut data data mahasiswa";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.21097F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.78903F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 84F));
            tableLayoutPanel1.Location = new Point(179, 96);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.77778F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.22222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Size = new Size(445, 97);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Visible = false;
            // 
            // lbljmlMhs
            // 
            lbljmlMhs.AutoSize = true;
            lbljmlMhs.Location = new Point(345, 70);
            lbljmlMhs.Name = "lbljmlMhs";
            lbljmlMhs.Size = new Size(112, 15);
            lbljmlMhs.TabIndex = 2;
            lbljmlMhs.Text = "Jumlah Mahasiswa :";
            // 
            // HomepageDosen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbljmlMhs);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblHpgDosen);
            Name = "HomepageDosen";
            Text = "HomepageDosen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHpgDosen;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbljmlMhs;
    }
}