using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.Model
{
    internal class Lichlamviec
    {
        private String MaLLV;
        private String MaNV;
        private DateTime NgayLV;
        private TimeSpan ThoigianLV;
        private String Ghichu;

        public Lichlamviec() { }
        public Lichlamviec(String MaLLV, String MaNV, DateTime NgayLV, TimeSpan ThoigianLV, String Ghichu)
        {
            this.MaLLV = MaLLV;
            this.MaNV = MaNV;
            this.NgayLV = NgayLV;
            this.ThoigianLV = ThoigianLV;
            this.Ghichu = Ghichu;
        }
        public String getMaLLV() { return MaLLV; }
        public String getMaNV() { return MaNV; }
        public DateTime getNgayLV() { return NgayLV; }
        public TimeSpan getThoigianLV() { return ThoigianLV; }
        public String getGhichu() { return Ghichu; }
        public void setMaLLV(String MaLLV) { this.MaLLV = MaLLV; }
        public void setMaNV(String MaNV) { this.MaNV = MaNV; }
        public void setNgayLV(DateTime NgayLV) { this.NgayLV = NgayLV; }
        public void setThoigianLV(TimeSpan ThoigianLV) { this.ThoigianLV = ThoigianLV; }
        public void setGhichu(String Ghichu) { this.Ghichu = Ghichu; }

        public String toString()
        {
            return MaLLV + MaNV + NgayLV + ThoigianLV + Ghichu;
        }
    }
}
