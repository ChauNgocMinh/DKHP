namespace DKHP.View
{
    partial class frmQLHocPhan
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
            groupBox1 = new GroupBox();
            dgDSHP = new DataGridView();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            MaxStudents = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnXoa = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            txtCourseName = new TextBox();
            label3 = new Label();
            txtCourseID = new TextBox();
            label4 = new Label();
            txtMaxStudents = new TextBox();
            label1 = new Label();
            cbbDepartment = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDSHP).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgDSHP);
            groupBox1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1, 309);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1015, 436);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách học phần";
            // 
            // dgDSHP
            // 
            dgDSHP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSHP.Columns.AddRange(new DataGridViewColumn[] { CourseID, CourseName, Department, MaxStudents });
            dgDSHP.Location = new Point(0, 29);
            dgDSHP.Name = "dgDSHP";
            dgDSHP.RowHeadersWidth = 51;
            dgDSHP.RowTemplate.Height = 29;
            dgDSHP.Size = new Size(1015, 405);
            dgDSHP.TabIndex = 0;
            dgDSHP.CellContentClick += dgTDHV_CellContentClick;
            dgDSHP.CellEndEdit += dgTDHV_CellEndEdit;
            // 
            // CourseID
            // 
            CourseID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseID.HeaderText = "Mã học phần";
            CourseID.MinimumWidth = 6;
            CourseID.Name = "CourseID";
            // 
            // CourseName
            // 
            CourseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CourseName.HeaderText = "Tên học phần";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            // 
            // Department
            // 
            Department.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Department.HeaderText = "Giáo viên bộ môn";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            // 
            // MaxStudents
            // 
            MaxStudents.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaxStudents.HeaderText = "Số lượng học sinh";
            MaxStudents.MinimumWidth = 6;
            MaxStudents.Name = "MaxStudents";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(81, 54);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(81, 111);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 37);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(81, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 37);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(739, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 235);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 49);
            label2.Name = "label2";
            label2.Size = new Size(145, 29);
            label2.TabIndex = 10;
            label2.Text = "Mã học phần";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(245, 102);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(418, 27);
            txtCourseName.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 102);
            label3.Name = "label3";
            label3.Size = new Size(150, 29);
            label3.TabIndex = 11;
            label3.Text = "Tên học phần";
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(245, 51);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(418, 27);
            txtCourseID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 152);
            label4.Name = "label4";
            label4.Size = new Size(193, 29);
            label4.TabIndex = 12;
            label4.Text = "Giáo viên bộ môn";
            // 
            // txtMaxStudents
            // 
            txtMaxStudents.Location = new Point(245, 208);
            txtMaxStudents.Name = "txtMaxStudents";
            txtMaxStudents.Size = new Size(418, 27);
            txtMaxStudents.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 208);
            label1.Name = "label1";
            label1.Size = new Size(195, 29);
            label1.TabIndex = 16;
            label1.Text = "Số lượng học sinh";
            // 
            // cbbDepartment
            // 
            cbbDepartment.FormattingEnabled = true;
            cbbDepartment.Location = new Point(245, 152);
            cbbDepartment.Name = "cbbDepartment";
            cbbDepartment.Size = new Size(418, 28);
            cbbDepartment.TabIndex = 18;
            // 
            // frmQLHocPhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1023, 745);
            Controls.Add(cbbDepartment);
            Controls.Add(txtMaxStudents);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtCourseName);
            Controls.Add(label3);
            Controls.Add(txtCourseID);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "frmQLHocPhan";
            Text = "frmQLHocPhan";
            Load += frmQLHocPhan_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDSHP).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dgDSHP;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnXoa;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn MaxStudents;
        private Label label2;
        private TextBox txtCourseName;
        private Label label3;
        private TextBox txtCourseID;
        private Label label4;
        private TextBox txtMaxStudents;
        private Label label1;
        private ComboBox cbbDepartment;
    }
}