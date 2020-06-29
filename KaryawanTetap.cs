using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Lab_9.Class_Induk;

namespace Tugas_Lab_9.Class_Anak
{
    public class KaryawanTetap: Karyawan
    {
        public double Gajian { get; set; }
        public override double Penghasilan()
        {
            return Gajian;
        }
    }
}