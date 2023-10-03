namespace ex1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSoN = new TextBox();
            txtKetqua = new TextBox();
            txtSoM = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(238, 23);
            label1.Name = "label1";
            label1.Size = new Size(285, 32);
            label1.TabIndex = 0;
            label1.Text = "Thuc hien cac phep tinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(151, 86);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhap so N";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(150, 156);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 2;
            label3.Text = "Nhap so M";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(159, 227);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 3;
            label4.Text = "Ket qua";
            // 
            // txtSoN
            // 
            txtSoN.Location = new Point(270, 87);
            txtSoN.Name = "txtSoN";
            txtSoN.Size = new Size(316, 23);
            txtSoN.TabIndex = 4;
            // 
            // txtKetqua
            // 
            txtKetqua.Location = new Point(270, 228);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.Size = new Size(316, 23);
            txtKetqua.TabIndex = 5;
            // 
            // txtSoM
            // 
            txtSoM.Location = new Point(270, 157);
            txtSoM.Name = "txtSoM";
            txtSoM.Size = new Size(316, 23);
            txtSoM.TabIndex = 6;
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCong.Location = new Point(135, 308);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(60, 51);
            btnCong.TabIndex = 7;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTru.Location = new Point(215, 308);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(60, 51);
            btnTru.TabIndex = 8;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhan.Location = new Point(295, 308);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(60, 51);
            btnNhan.TabIndex = 9;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChia.Location = new Point(376, 308);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(60, 51);
            btnChia.TabIndex = 10;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(459, 308);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(60, 51);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button5_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(549, 308);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(77, 51);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtSoM);
            Controls.Add(txtKetqua);
            Controls.Add(txtSoN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSoN;
        private TextBox txtKetqua;
        private TextBox txtSoM;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnXoa;
        private Button btnThoat;
    }
}