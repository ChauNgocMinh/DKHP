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

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtinnhanvien TTNV = new frmThongtinnhanvien();
            TTNV.Size = new Size(1224, 975);
            TTNV.ShowDialog();
        }

        private void lịchNghỉPhépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichnghiphep LNP = new frmLichnghiphep();
            LNP.Size = new Size(1224, 975);
            LNP.ShowDialog();
        }

        private void lịchLàmViệcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLichlamviec LLV = new frmLichlamviec();
            LLV.Size = new Size(1224, 975);
            LLV.ShowDialog();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChamcong CHC = new frmChamcong();
            CHC.Size = new Size(1224, 975);
            CHC.ShowDialog();
        }

        private void trìnhĐộHọcVấnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQLHocPhan TDHV = new frmQLHocPhan();
            TDHV.Size = new Size(1224, 975);
            TDHV.ShowDialog();
        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhongban PB = new frmPhongban();
            PB.Size = new Size(1224, 975);
            PB.ShowDialog();
        }

        private void quảnLýChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChucvu CV = new frmChucvu();
            CV.Size = new Size(1224, 975);
            CV.ShowDialog();
        }

        private void LuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLuong L = new frmLuong();
            L.Size = new Size(1224, 975);
            L.ShowDialog();
        }

        private void hỖTRỢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHotro HT = new frmHotro();
            HT.Size = new Size(1224, 975);
            HT.ShowDialog();
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
            if (PnDKHP.Visible == true)
            {
                PnDKHP.Visible = false;
            }
            else
            {
                PnDKHP.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "THÔNG TIN NHÂN VIÊN";
            pnView.Controls.Clear();
            frmThongtinnhanvien frm = new frmThongtinnhanvien();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }

        private void btnNghiPhep_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "LỊCH NGHỈ PHÉP";
            pnView.Controls.Clear();
            frmLichnghiphep frm = new frmLichnghiphep();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "LỊCH LÀM VIỆC";
            pnView.Controls.Clear();
            frmLichlamviec frm = new frmLichlamviec();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "CHẤM CÔNG";
            pnView.Controls.Clear();
            frmChamcong frm = new frmChamcong();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
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

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "QUẢN LÝ PHÒNG BAN";
            pnView.Controls.Clear();
            frmPhongban frm = new frmPhongban();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "QUẢN LÝ CHỨC VỤ";
            pnView.Controls.Clear();
            frmChucvu frm = new frmChucvu();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "QUẢN LÝ LƯƠNG";
            pnView.Controls.Clear();
            frmLuong frm = new frmLuong();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }

        private void btnHoTro_Click_1(object sender, EventArgs e)
        {
            LabTitle.Text = "HỖ TRỢ";
            pnView.Controls.Clear();
            frmHotro frm = new frmHotro();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabTitle.Text = "HỖ TRỢ";
            pnView.Controls.Clear();
            frmThongtinnhanvien frm = new frmThongtinnhanvien();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnView.Controls.Add(frm);
            frm.Show();
        }
    }
}
