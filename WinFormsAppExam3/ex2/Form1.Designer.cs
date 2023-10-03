namespace ex2
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
            groupBox1 = new GroupBox();
            txtB = new TextBox();
            txtA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnBCNN = new RadioButton();
            btnUCLN = new RadioButton();
            groupBox3 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnTim = new Button();
            txtKetqua = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(401, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhap";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtB
            // 
            txtB.Location = new Point(55, 106);
            txtB.Name = "txtB";
            txtB.Size = new Size(316, 23);
            txtB.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(55, 36);
            txtA.Name = "txtA";
            txtA.Size = new Size(316, 23);
            txtA.TabIndex = 2;
            txtA.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 110);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "B:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "A:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBCNN);
            groupBox2.Controls.Add(btnUCLN);
            groupBox2.Location = new Point(417, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(179, 169);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chon tim";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnBCNN
            // 
            btnBCNN.AutoSize = true;
            btnBCNN.Location = new Point(37, 94);
            btnBCNN.Name = "btnBCNN";
            btnBCNN.Size = new Size(58, 19);
            btnBCNN.TabIndex = 5;
            btnBCNN.Text = "BCNN";
            btnBCNN.UseVisualStyleBackColor = true;
            // 
            // btnUCLN
            // 
            btnUCLN.AutoSize = true;
            btnUCLN.Location = new Point(38, 50);
            btnUCLN.Name = "btnUCLN";
            btnUCLN.Size = new Size(56, 19);
            btnUCLN.TabIndex = 4;
            btnUCLN.Text = "UCLN";
            btnUCLN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnTim);
            groupBox3.Controls.Add(txtKetqua);
            groupBox3.Location = new Point(10, 179);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(586, 151);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ket qua";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(407, 80);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 50);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button3_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(246, 80);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 50);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTim.Location = new Point(76, 80);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(107, 50);
            btnTim.TabIndex = 1;
            btnTim.Text = "Tim";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += button1_Click;
            // 
            // txtKetqua
            // 
            txtKetqua.Location = new Point(41, 36);
            txtKetqua.Name = "txtKetqua";
            txtKetqua.Size = new Size(503, 23);
            txtKetqua.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 332);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnTim;
        private TextBox txtKetqua;
        private RadioButton btnBCNN;
        private RadioButton btnUCLN;
    }
}