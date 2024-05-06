using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.Model
{
    internal class Phongban
    {
        private String MaPB;
        private String TenPB;
        private int SDTPB;

        public Phongban() { }
        public Phongban(String MaPB, String TenPB, int SDTPB)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
            this.SDTPB = SDTPB;
        }
        public String getMaPB() { return MaPB; }
        public String getTenPB() { return TenPB; }
        public int getSDTPB() { return SDTPB; }
        public void setMaPB(String MaPB) { this.MaPB = MaPB; }
        public void setTenPB(String TenPB) { this.TenPB = TenPB; }
        public void setSDTPB(int SDTPB) { this.SDTPB = SDTPB; }

        public String toString()
        {
            return MaPB + TenPB + SDTPB;
        }
    }
}
