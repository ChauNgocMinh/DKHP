namespace DKHP
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 107);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 226);
            label2.Name = "label2";
            label2.Size = new Size(110, 29);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(188, 107);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(402, 36);
            txtUserName.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(188, 226);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(402, 36);
            txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(300, 315);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(139, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(236, 25);
            label3.Name = "label3";
            label3.Size = new Size(222, 38);
            label3.TabIndex = 6;
            label3.Text = "ĐĂNG NHẬP";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 482);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnLogin;
        private Label label3;
    }
}