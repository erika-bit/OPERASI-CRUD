using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Lab_9.Class_Induk;

namespace Tugas_Lab_9.Class_Anak
{
    public class Sales: Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int Bonus           { get; set; }
        public override double  Penghasilan()
        {
            return JumlahPenjualan * Bonus;
        }
    }
}