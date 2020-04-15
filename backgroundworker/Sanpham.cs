using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backgroundworker
{
    [Serializable]
    public class Sanpham : Loaisp
    { public string ma { get; set; }
        public string tensp { get; set; }
        public string soluong { get; set; }
        public int dongia { get; set; }
        public bool kichco { get; set; }
        public Loaisp loaisp { get; set; }
        public override string ToString()
        {
            return tensp;
        }
    }
}
