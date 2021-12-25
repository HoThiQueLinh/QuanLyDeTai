using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDeTai
{
    class DeTai
    {
        private string madt;
        private string tendt;
        private DateTime ngaybd;
        private DateTime ngaykt;
        private string macd;
        public DeTai()
        {

        }
        public DeTai(string madt, string tendt, DateTime ngaybd, DateTime ngaykt, string macd)
        {
            this.madt = madt;
            this.tendt = tendt;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
            this.macd = macd;
        }

        public string Madt { get => madt; set => madt = value; }
        public string Tendt { get => tendt; set => tendt = value; }
        public DateTime Ngaybd { get => ngaybd; set => ngaybd = value; }
        public DateTime Ngaykt { get => ngaykt; set => ngaykt = value; }
        public string Macd { get => macd; set => macd = value; }
    }
}
