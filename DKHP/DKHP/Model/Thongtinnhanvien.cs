using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DKHP.Model
{
    internal class Thongtinnhanvien
    {
        private String MaNV;
        private String HoTenNV;
        private DateTime Ngaysinh;
        private String Gioitinh;
        private String Quequan;
        private String Dantoc;
        private int SDT;
        private String Email;
        private String Bacluong;
        private String MaPB;
        private String MaCV;
        private String MaTDHV;
        private String Tinhtrang;

        public Thongtinnhanvien() { }
        public Thongtinnhanvien(String MaNV, String HoTenNV, DateTime Ngaysinh, String Gioitinh, String Quequan, 
            String Dantoc, int SDT, String Email, String Bacluong, String MaPB, String MaCV, String MaTDHV, String Tinhtrang)
        {
            this.MaNV = MaNV;
            this.HoTenNV = HoTenNV;
            this.Ngaysinh = Ngaysinh;
            this.Gioitinh = Gioitinh;
            this.Quequan = Quequan;
            this.Dantoc = Dantoc;
            this.SDT = SDT;
            this.Email = Email;
            this.Bacluong = Bacluong;
            this.MaPB = MaPB;
            this.MaCV = MaCV;
            this.MaTDHV = MaTDHV;
            this.Tinhtrang = Tinhtrang;
        }
        public String getMaNV() { return MaNV; }
        public String getHoTenNV() { return HoTenNV; }
        public DateTime getNgaysinh() { return Ngaysinh; }
        public String getGioitinh() { return Gioitinh; }
        public String getQuequan() { return Quequan; }
        public String getDantoc() { return Dantoc; }
        public int getSDT() { return SDT; }
        public String getEmail() { return Email; }
        public String getBacluong() { return Bacluong; }
        public String getMaPB() { return MaPB; }
        public String getMaCV() { return MaCV; }
        public String getMaTDHV() { return MaTDHV; }
        public String getTinhtrang() { return Tinhtrang; }
        public void setMaNV(String MaNV) { this.MaNV = MaNV; }
        public void setHoTenNV(String HoTenNV) { this.HoTenNV = HoTenNV; }
        public void setNgaysinh(DateTime Ngaysinh) { this.Ngaysinh = Ngaysinh; }
        public void setGioitinh(String Gioitinh) { this.Gioitinh = Gioitinh; }
        public void setQuequan(String Quequan) { this.Quequan = Quequan; }
        public void setDantoc(String Dantoc) { this.Dantoc = Dantoc; }
        public void setSDT(int SDT) { this.SDT = SDT; }
        public void setEmail(String Email) { this.Email = Email; }
        public void setBacluong(String Bacluong) { this.Bacluong = Bacluong; }
        public void setMaPB(String MaPB) { this.MaPB = MaPB; }
        public void setMaCV(String MaCV) { this.MaCV = MaCV; }
        public void setMaTDHV(String MaTDHV) { this.MaTDHV = MaTDHV; }
        public void setTinhtrang(String Tinhtrang) { this.Tinhtrang = Tinhtrang; }
        public String toString()
        {
            return MaNV + HoTenNV + Ngaysinh + Gioitinh + Quequan + Dantoc + SDT + Email + Bacluong + MaPB + MaCV + MaTDHV + Tinhtrang ;
        }

    }
}
