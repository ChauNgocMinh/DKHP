using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.Model
{
    internal class Chucvu
    {
        private String MaCV;
        private String TenCV;

        public Chucvu() { }
        public Chucvu(String MaCV, String TenCV)
        {
            this.MaCV = MaCV;
            this.TenCV = TenCV;
        }
        public String getMaCV() { return MaCV; }
        public String getTenCV() { return TenCV; }
        public void setMaCV(String MaCV) { this.MaCV = MaCV; }
        public void setTenCV(String TenCV) { this.TenCV = TenCV; }

        public String toString()
        {
            return MaCV + TenCV;
        }

    }
}
