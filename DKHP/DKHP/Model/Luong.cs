using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.Model
{
    internal class Luong
    {
        private String Bacluong;
        private decimal HSluong;
        private int LuongCB;
        private decimal HSPhucap;

        public Luong() { }
        public Luong(String Bacluong, decimal HSluong, int LuongCB, decimal HSPhucap)
        {
            this.Bacluong = Bacluong;
            this.HSluong = HSluong;
            this.LuongCB = LuongCB;
            this.HSPhucap = HSPhucap;
        }
        public String getBacluong() { return Bacluong; }
        public Decimal getHSluong() { return HSluong; }
        public int getLuongCB() { return LuongCB; }
        public Decimal getHSPhucap() { return HSPhucap; }
        public void setBacluong(String Bacluong) { this.Bacluong = Bacluong; }
        public void setHSluong(Decimal HSluong) { this.HSluong = HSluong; }
        public void setLuongCB(int LuongCB) { this.LuongCB = LuongCB; }
        public void setHSPhucap(Decimal HSPhucap) { this.HSPhucap = HSPhucap; }

        public String toString()
        {
            return Bacluong + HSluong + LuongCB + HSPhucap;
        }
    }
}
