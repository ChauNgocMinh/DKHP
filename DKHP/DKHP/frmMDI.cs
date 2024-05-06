using Microsoft.VisualBasic.ApplicationServices;
using DKHP.Share;
using DKHP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DKHP
{
    public partial class frmMDI : Form
    {
        private int userID;
        private string typeName;
        private string displayName;
        private string Key;
        public frmMDI(int userID, string displayName, string typeName, string key)
        {
            InitializeComponent();

            this.userID = userID;
            this.typeName = typeName;
            this.displayName = displayName;
            this.Key = key;

            InitializeUserInfo();
        }

        private void InitializeUserInfo()
        {
            labName.Text = "Hello: " + displayName;
            labUserType.Text = "Chức vụ: " + typeName;
        }

        private void trìnhĐộHọcVấnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLHocPhan TDHV = new frmQLHocPhan();
            TDHV.Size = new Size(1224, 975);
            TDHV.ShowDialog();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Đóng ứng dụng", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnQLTaiChinh_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "QUẢN LÝ HỌC PHẦN";
            pnView.Controls.Clear();
            frmQLHocPhan frm = new frmQLHocPhan();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHocVan_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "TRÌNH ĐỘ HỌC VẤN";
            pnView.Controls.Clear();
            frmQLHocPhan frm = new frmQLHocPhan();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }

    }
}
