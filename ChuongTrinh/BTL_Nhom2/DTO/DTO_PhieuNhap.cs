using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuNhap
    {

        string mapn, masp;
        int sln;
        float dgn;
        string ngayn, mancc;

        public string Mapn { get => mapn; set => mapn = value; }
        public string Masp { get => masp; set => masp = value; }
        public int Sln { get => sln; set => sln = value; }
        public float Dgn { get => dgn; set => dgn = value; }
        public string Ngayn { get => ngayn; set => ngayn = value; }
        public string Mancc { get => mancc; set => mancc = value; }
    }
}
