using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using DKHP.Share;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace DKHP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Chuyển đến form đăng ký
            frmRegister rgt = new frmRegister();
            rgt.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPass.Text;

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và mật khẩu.");
                return;
            }

            // Thực hiện truy vấn để kiểm tra người dùng và mật khẩu từ cơ sở dữ liệu
            using (SqlConnection connection = DatabaseHelper.getConnection())
            {
                string query = "SELECT UserID, UserName, UserType FROM Users WHERE UserName = @UserName AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            int userID = Convert.ToInt32(reader["UserID"]);
                            string userType = reader["UserType"].ToString();
                            string displayName = reader["UserName"].ToString();
                            int typeID = Convert.ToInt32(reader["UserType"]);
                            string typeName = GetTypeName(typeID);
                            string key = GetKey(typeID);

                            DatabaseHelper.ExecuteQuery(@"EXECUTE AS LOGIN = '"+ key + "';");

                            this.Hide(); // Ẩn form hiện tại
                            frmMDI mdiForm = new frmMDI(userID, displayName, typeName, key);
                            mdiForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi đăng nhập: " + ex.Message);
                    }
                }
            }
        }

        private string GetTypeName(int typeID)
        {
            using (SqlConnection connection = DatabaseHelper.getConnection())
            {
                string query = "SELECT TypeName FROM UserTypes WHERE TypeID = @TypeID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeID", typeID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            return "Unknown";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi lấy thông tin TypeName từ cơ sở dữ liệu: " + ex.Message);
                        return "Unknown";
                    }
                }
            }
        }
        private string GetKey(int typeID)
        {
            using (SqlConnection connection = DatabaseHelper.getConnection())
            {
                string query = "SELECT [Key] FROM UserTypes WHERE TypeID = @TypeID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeID", typeID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            return "Unknown";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi lấy thông tin Key từ cơ sở dữ liệu: " + ex.Message);
                        return "Unknown";
                    }
                }
            }
        }
    }
}
