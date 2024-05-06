using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKHP.Model
{
    internal class Trinhdohocvan
    {
        private String MaTDHV;
        private String TenTDHV;
        private String CNganh;

        public Trinhdohocvan() { }
        public Trinhdohocvan(String MaTDHV, String TenTDHV, String CNganh)
        {
            this.MaTDHV = MaTDHV;
            this.TenTDHV = TenTDHV;
            this.CNganh = CNganh;
        }
        public String getMaTDHV() { return MaTDHV; }
        public String getTenTDHV() { return TenTDHV; }
        public String getCNganh() { return CNganh; }
        public void setMaTDHV(String MaTDHV) { this.MaTDHV = MaTDHV; }
        public void setTenTDHV(String TenTDHV) { this.TenTDHV = TenTDHV; }
        public void setCNganh(String CNganh) { this.CNganh = CNganh; }

        public String toString()
        {
            return MaTDHV + TenTDHV + CNganh;
        }
    }
}
