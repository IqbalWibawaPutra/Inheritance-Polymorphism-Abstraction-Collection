using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas8
{
    public abstract class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}