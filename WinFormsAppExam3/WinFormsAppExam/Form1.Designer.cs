namespace WinFormsAppExam
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
            txtSecurityCode = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button0 = new Button();
            button = new Button();
            buttonC = new Button();
            label2 = new Label();
            listBoxLog = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 28);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Security code";
            // 
            // txtSecurityCode
            // 
            txtSecurityCode.AccessibleName = "txtSecurityCode";
            txtSecurityCode.Location = new Point(132, 25);
            txtSecurityCode.Name = "txtSecurityCode";
            txtSecurityCode.PasswordChar = '*';
            txtSecurityCode.ReadOnly = true;
            txtSecurityCode.Size = new Size(133, 27);
            txtSecurityCode.TabIndex = 1;
            txtSecurityCode.TextAlign = HorizontalAlignment.Center;
            txtSecurityCode.TextChanged += txtSecurityCode_TextChanged;
            txtSecurityCode.KeyDown += txtSecurityCode_KeyDown;
            // 
            // button1
            // 
            button1.AccessibleName = "btn1";
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(62, 114);
            button1.MaximumSize = new Size(50, 33);
            button1.Name = "button1";
            button1.Size = new Size(50, 33);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "btn2";
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(118, 114);
            button2.MaximumSize = new Size(50, 33);
            button2.Name = "button2";
            button2.Size = new Size(50, 33);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AccessibleName = "btn3";
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(174, 114);
            button3.MaximumSize = new Size(50, 33);
            button3.Name = "button3";
            button3.Size = new Size(50, 33);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.AccessibleName = "btn6";
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(174, 169);
            button6.MaximumSize = new Size(50, 33);
            button6.Name = "button6";
            button6.Size = new Size(50, 33);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.AccessibleName = "btn5";
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(118, 169);
            button5.MaximumSize = new Size(50, 33);
            button5.Name = "button5";
            button5.Size = new Size(50, 33);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.AccessibleName = "btn4";
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(62, 168);
            button4.MaximumSize = new Size(50, 33);
            button4.Name = "button4";
            button4.Size = new Size(50, 33);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.AccessibleName = "btn8";
            button8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(118, 226);
            button8.MaximumSize = new Size(50, 33);
            button8.Name = "button8";
            button8.Size = new Size(50, 33);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.AccessibleName = "btn9";
            button9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(174, 226);
            button9.MaximumSize = new Size(50, 33);
            button9.Name = "button9";
            button9.Size = new Size(50, 33);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.AccessibleName = "btn7";
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(62, 226);
            button7.MaximumSize = new Size(50, 33);
            button7.Name = "button7";
            button7.Size = new Size(50, 33);
            button7.TabIndex = 10;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button0
            // 
            button0.AccessibleName = "btn0";
            button0.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button0.Location = new Point(230, 226);
            button0.Name = "button0";
            button0.Size = new Size(48, 34);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button
            // 
            button.AccessibleName = "btn=";
            button.BackColor = Color.FromArgb(128, 128, 255);
            button.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button.ForeColor = Color.FromArgb(255, 128, 255);
            button.Location = new Point(230, 168);
            button.Name = "button";
            button.Size = new Size(48, 35);
            button.TabIndex = 12;
            button.Text = "=";
            button.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            buttonC.AccessibleName = "btnC";
            buttonC.BackColor = Color.FromArgb(255, 192, 128);
            buttonC.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.ForeColor = Color.FromArgb(128, 255, 128);
            buttonC.Location = new Point(230, 114);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(48, 34);
            buttonC.TabIndex = 13;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 283);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 14;
            label2.Text = "Assses log";
            // 
            // listBoxLog
            // 
            listBoxLog.FormattingEnabled = true;
            listBoxLog.ItemHeight = 20;
            listBoxLog.Location = new Point(22, 320);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.Size = new Size(304, 164);
            listBoxLog.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 506);
            Controls.Add(listBoxLog);
            Controls.Add(label2);
            Controls.Add(buttonC);
            Controls.Add(button);
            Controls.Add(button0);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSecurityCode);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSecurityCode;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button8;
        private Button button9;
        private Button button7;
        private Button button0;
        private Button button;
        private Button buttonC;
        private Label label2;
        private ListBox listBoxLog;
    }
}