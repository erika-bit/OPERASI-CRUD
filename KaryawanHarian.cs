using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Lab_9.Class_Induk;

namespace Tugas_Lab_9.Class_Anak
{
    public class KaryawanHarian: Karyawan
    {
        public int JamKerja { get; set; }
        public int Upah     { get; set; }
        public override double Penghasilan()
        {
            return JamKerja * Upah;
        }
    }
}
