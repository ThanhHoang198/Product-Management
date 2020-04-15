using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backgroundworker
{[Serializable]
    public class Danhmuc
    {   public string maDM { get; set; }
        public string  tenDM { get; set; }

        public List<Loaisp> dslsp { get; set; }

        public Danhmuc()
        {
            dslsp = new List<Loaisp>();
        }
        public void themsp(Loaisp Lsp)
        {
            dslsp.Add(Lsp);
          Lsp.tendm = this;

        }
        public override string ToString()
        {
            return tenDM;
        }
    }
}
