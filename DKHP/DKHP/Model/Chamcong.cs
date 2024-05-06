using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.Model
{
    internal class Chamcong
    {
        private String MaCC;
        private String MaNV;
        private DateTime NgayChamCong;
        private TimeSpan GioVao;
        private TimeSpan GioRa;

        public Chamcong() { }
        public Chamcong(String MaCC, String MaNV, DateTime NgayChamCong, TimeSpan GioVao, TimeSpan GioRa)
        {
            this.MaCC = MaCC;
            this.MaNV = MaNV;
            this.NgayChamCong = NgayChamCong;
            this.GioVao = GioVao;
            this.GioRa = GioRa;
        } 
        public String getMaCC() { return MaCC; }
        public String getMaNV() { return MaNV; }
        public DateTime getNgayChamCong() { return NgayChamCong; }
        public TimeSpan getGioVao() { return GioVao; }
        public TimeSpan getGioRa() { return GioRa; }
        public void setMaCC(String MaCC) { this.MaCC = MaCC; }
        public void setMaNV(String MaNV) { this.MaNV = MaNV; }
        public void setNgayChamCong(DateTime NgayChamCong) { this.NgayChamCong = NgayChamCong; }
        public void setGioVao(TimeSpan GioVao) { this.GioVao = GioVao; }
        public void setGioRa(TimeSpan GioRa) { this.GioRa = GioRa; }

        public String toString()
        {
            return MaCC + MaNV + NgayChamCong + GioVao + GioRa;
        }
    }
}
