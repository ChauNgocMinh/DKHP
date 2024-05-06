using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.Model
{
    internal class Lichnghiphep
    {
        private String MaLNP;
        private String MaNV;
        private DateTime Ngaybatdau;
        private DateTime Ngayketthuc;
        private String Lydo;

        public Lichnghiphep() { }
        public Lichnghiphep(String MaLNP, String MaNV, DateTime Ngaybatdau, DateTime Ngayketthuc, String Lydo)
        {
            this.MaLNP = MaLNP;
            this.MaNV = MaNV;
            this.Ngaybatdau = Ngaybatdau;
            this.Ngayketthuc = Ngayketthuc;
            this.Lydo = Lydo;
        }
        public String getMaLNP() { return MaLNP; }
        public String getMaNV() { return MaNV; }
        public DateTime getNgaybatdau() { return Ngaybatdau; }
        public DateTime getNgayketthuc() { return Ngayketthuc; }
        public String getLydo() { return Lydo; }
        public void setMaLNP(String MaLNP) { this.MaLNP = MaLNP; }
        public void setMaNV(String MaNV) { this.MaNV = MaNV; }
        public void setNgaybatdau(DateTime Ngaybatdau) { this.Ngaybatdau = Ngaybatdau; }
        public void setNgayketthuc(DateTime Ngayketthuc) { this.Ngayketthuc = Ngayketthuc; }
        public void setLydo(String Lydo ) { this.Lydo = Lydo; }

        public String toString()
        {
            return MaLNP + MaNV + Ngaybatdau + Ngayketthuc + Lydo;
        }
    }
}
