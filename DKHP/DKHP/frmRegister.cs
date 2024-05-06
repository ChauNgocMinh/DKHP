using QLNhansu.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhansu
{
    public partial class frmRegister : Form
    {
        private LoginandRegisterController authentication;

        public frmRegister()
        {
            InitializeComponent();
            authentication = new LoginandRegisterController();
        }

        // kiểm tra xem địa chỉ email có hợp lệ hay không
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string password = textBox3.Text;
            string confirmPassword = textBox4.Text;

            // Kiểm tra các trường có được điền đầy đủ không
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Kiểm tra mật khẩu và xác nhận mật khẩu có trùng khớp không
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không trùng khớp.");
                return;
            }

            // Kiểm tra định dạng email hợp lệ
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;
            }

            // Kiểm tra xem tên đăng nhập đã tồn tại chưa
            if (authentication.UsernameExists(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                return;
            }

            // Đăng ký tài khoản
            bool registrationSuccess = authentication.RegisterUser(username, password, email);

            if (registrationSuccess)
            {
                MessageBox.Show("Đăng ký thành công.");
                // Chuyển đến form đăng nhập
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Chuyển đến form đăng nhập
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
