namespace Database_Connection
{
    partial class ConnectSQLDatabase
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
            btnConnect = new Button();
            btnDisconnect = new Button();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(69, 56);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(450, 54);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect to SQL server Database";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisconnect.Location = new Point(147, 175);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(286, 52);
            btnDisconnect.TabIndex = 1;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // ConnectSQLDatabase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 319);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Name = "ConnectSQLDatabase";
            Text = "ConnectSQLDatabase";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnect;
        private Button btnDisconnect;
    }
}