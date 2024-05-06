namespace DKHP
{
    partial class frmRegister
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 77);
            label1.Name = "label1";
            label1.Size = new Size(185, 29);
            label1.TabIndex = 0;
            label1.Text = "Enter User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 154);
            label2.Name = "label2";
            label2.Size = new Size(131, 29);
            label2.TabIndex = 1;
            label2.Text = "Enter Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 239);
            label3.Name = "label3";
            label3.Size = new Size(170, 29);
            label3.TabIndex = 2;
            label3.Text = "Enter Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 322);
            label4.Name = "label4";
            label4.Size = new Size(201, 29);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(258, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 36);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(258, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 36);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(258, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(402, 36);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(258, 315);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(402, 36);
            textBox4.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(40, 411);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(113, 42);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Đăng ký ";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(427, 411);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(233, 42);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Đăng nhập lại nào";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(267, 9);
            label5.Name = "label5";
            label5.Size = new Size(177, 38);
            label5.TabIndex = 10;
            label5.Text = "ĐĂNG KÝ";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 482);
            Controls.Add(label5);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnRegister;
        private Button btnLogin;
        private Label label5;
    }
}