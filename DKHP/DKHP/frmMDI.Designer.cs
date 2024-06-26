﻿namespace DKHP
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            btnClose = new Button();
            panel1 = new Panel();
            btnHoTro = new Button();
            btnQLTaiChinh = new Button();
            btnDKHP = new Button();
            panel2 = new Panel();
            labUserType = new Label();
            labName = new Label();
            pnView = new Panel();
            panel5 = new Panel();
            LabTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(23, 21, 32);
            btnClose.Dock = DockStyle.Bottom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(0, 838);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(213, 53);
            btnClose.TabIndex = 1;
            btnClose.Text = "Thoát";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 21, 32);
            panel1.Controls.Add(btnHoTro);
            panel1.Controls.Add(btnQLTaiChinh);
            panel1.Controls.Add(btnDKHP);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 891);
            panel1.TabIndex = 3;
            // 
            // btnHoTro
            // 
            btnHoTro.BackColor = Color.FromArgb(23, 21, 32);
            btnHoTro.Dock = DockStyle.Top;
            btnHoTro.FlatAppearance.BorderSize = 0;
            btnHoTro.FlatStyle = FlatStyle.Flat;
            btnHoTro.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoTro.ForeColor = Color.White;
            btnHoTro.Location = new Point(0, 231);
            btnHoTro.Margin = new Padding(0);
            btnHoTro.Name = "btnHoTro";
            btnHoTro.Size = new Size(213, 53);
            btnHoTro.TabIndex = 19;
            btnHoTro.Text = "Hỗ trợ";
            btnHoTro.TextAlign = ContentAlignment.MiddleLeft;
            btnHoTro.UseVisualStyleBackColor = false;
            // 
            // btnQLTaiChinh
            // 
            btnQLTaiChinh.BackColor = Color.FromArgb(23, 21, 32);
            btnQLTaiChinh.Dock = DockStyle.Top;
            btnQLTaiChinh.FlatAppearance.BorderSize = 0;
            btnQLTaiChinh.FlatStyle = FlatStyle.Flat;
            btnQLTaiChinh.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnQLTaiChinh.ForeColor = Color.White;
            btnQLTaiChinh.Image = (Image)resources.GetObject("btnQLTaiChinh.Image");
            btnQLTaiChinh.ImageAlign = ContentAlignment.MiddleRight;
            btnQLTaiChinh.Location = new Point(0, 178);
            btnQLTaiChinh.Margin = new Padding(0);
            btnQLTaiChinh.Name = "btnQLTaiChinh";
            btnQLTaiChinh.Size = new Size(213, 53);
            btnQLTaiChinh.TabIndex = 15;
            btnQLTaiChinh.Text = "Quản lý học phần";
            btnQLTaiChinh.TextAlign = ContentAlignment.MiddleLeft;
            btnQLTaiChinh.UseVisualStyleBackColor = false;
            btnQLTaiChinh.Click += btnQLTaiChinh_Click;
            // 
            // btnDKHP
            // 
            btnDKHP.BackColor = Color.FromArgb(23, 21, 32);
            btnDKHP.Dock = DockStyle.Top;
            btnDKHP.FlatAppearance.BorderSize = 0;
            btnDKHP.FlatStyle = FlatStyle.Flat;
            btnDKHP.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDKHP.ForeColor = Color.White;
            btnDKHP.Image = (Image)resources.GetObject("btnDKHP.Image");
            btnDKHP.ImageAlign = ContentAlignment.MiddleRight;
            btnDKHP.Location = new Point(0, 125);
            btnDKHP.Margin = new Padding(0);
            btnDKHP.Name = "btnDKHP";
            btnDKHP.RightToLeft = RightToLeft.No;
            btnDKHP.Size = new Size(213, 53);
            btnDKHP.TabIndex = 16;
            btnDKHP.Text = "Quản lý người dùng";
            btnDKHP.TextAlign = ContentAlignment.MiddleLeft;
            btnDKHP.UseVisualStyleBackColor = false;
            btnDKHP.Click += btnDKHP_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 32, 39);
            panel2.Controls.Add(labUserType);
            panel2.Controls.Add(labName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(213, 125);
            panel2.TabIndex = 7;
            // 
            // labUserType
            // 
            labUserType.AutoSize = true;
            labUserType.ForeColor = Color.White;
            labUserType.Location = new Point(3, 73);
            labUserType.Name = "labUserType";
            labUserType.Size = new Size(68, 20);
            labUserType.TabIndex = 1;
            labUserType.Text = "Chức vụ: ";
            // 
            // labName
            // 
            labName.AutoSize = true;
            labName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labName.ForeColor = Color.White;
            labName.Location = new Point(3, 21);
            labName.Name = "labName";
            labName.Size = new Size(73, 28);
            labName.TabIndex = 0;
            labName.Text = "Hello: ";
            // 
            // pnView
            // 
            pnView.BackColor = Color.White;
            pnView.Dock = DockStyle.Bottom;
            pnView.Location = new Point(213, 99);
            pnView.Margin = new Padding(3, 4, 3, 4);
            pnView.Name = "pnView";
            pnView.Size = new Size(1016, 792);
            pnView.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(32, 30, 45);
            panel5.Controls.Add(LabTitle);
            panel5.Dock = DockStyle.Fill;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(213, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1016, 99);
            panel5.TabIndex = 6;
            // 
            // LabTitle
            // 
            LabTitle.AutoSize = true;
            LabTitle.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabTitle.Location = new Point(287, 21);
            LabTitle.Name = "LabTitle";
            LabTitle.Size = new Size(510, 53);
            LabTitle.TabIndex = 0;
            LabTitle.Text = "ĐĂNG KÝ HỌC PHẦN";
            LabTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMDI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 891);
            Controls.Add(panel5);
            Controls.Add(pnView);
            Controls.Add(panel1);
            Name = "frmMDI";
            Text = "Quản lý nhân sự";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnClose;
        private Panel panel1;
        private Panel pnView;
        private Panel panel5;
        private Label LabTitle;
        private Panel panel2;
        internal Button btnQLTaiChinh;
        internal Button btnDKHP;
        internal Button btnHoTro;
        private Label labUserType;
        private Label labName;
    }
}