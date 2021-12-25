using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDeTai
{
    class ChuDe
    {
        private string macd;
        private string tencd;
        public ChuDe()
        {

        }
        public ChuDe(string macd, string tencd)
        {
            this.macd = macd;
            this.tencd = tencd;
        }

        public string Macd { get => macd; set => macd = value; }
        public string Tencd { get => tencd; set => tencd = value; }
    }
}
