using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.Model
{
    internal class LoginandRegister
    {
        private int ID;
        private String UserName;
        private String Password;
        private String Email;

        public LoginandRegister() { }
        public LoginandRegister(int ID, String UserName, String Password, String Email)
        {
            this.ID = ID;
            this.UserName = UserName;
            this.Password = Password;
            this.Email = Email;
        }
        public int getID() { return ID; }
        public String getUserName() { return UserName; }
        public String getPassword() { return Password; }
        public String getEmail() { return Email; }
        public void setID(int ID) { this.ID = ID; }
        public void setUserName(String UserName) { this.UserName = UserName; }
        public void setPassword(String Password) { this.Password = Password; }
        public void setEmail(String Email) { this.Email = Email; }


        public String toString()
        {
            return ID + UserName + Password + Email;
        }
    }
}
