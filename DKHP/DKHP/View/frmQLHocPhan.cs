using Microsoft.VisualBasic;
using DKHP.Model;
using DKHP.Share;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKHP.View
{
    public partial class frmQLHocPhan : Form
    {
        public frmQLHocPhan()
        {
            InitializeComponent();
        }

        private void frmQLHocPhan_Load(object sender, EventArgs e)
        {
            string query = "SELECT DepartmentID, DepartmentName FROM Departments";
            DataTable departments = DatabaseHelper.GetData(query);
            if (departments.Rows.Count > 0)
            {
                foreach (DataRow row in departments.Rows)
                {
                    cbbDepartment.Items.Add(new KeyValuePair<int, string>((int)row["DepartmentID"], row["DepartmentName"].ToString()));
                }
                cbbDepartment.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO Courses (CourseId,CourseName, DepartmentID, MaxStudents) VALUES ('{txtCourseID.Text}','{txtCourseName.Text}', {cbbDepartment.SelectedItem}, {txtMaxStudents.Text})";
            DatabaseHelper.InsertData(query);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void dgTDHV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgTDHV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
