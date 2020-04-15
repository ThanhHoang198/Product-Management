using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backgroundworker
{
    [Serializable]
    public class Loaisp
    {
        public string maloaisp { get; set; }
        public string tenloaisp { get; set; }
        public List<Sanpham> dssp { get; set; }
        public Danhmuc tendm { get; set; }

        public Loaisp() 
        {
            dssp = new List<Sanpham>();
        }
        public void themsp(Sanpham sp)
        {
            dssp.Add(sp);
            sp.loaisp = this;

        }
        public override string ToString()
        {
            return tenloaisp;
        }
    }
}
