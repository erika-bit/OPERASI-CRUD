using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Lab_9.Class_Induk
{
    public abstract class Karyawan
    {
        public string NAMA  { get; set; }
        public string NIK   { get; set; }
        public string JUMKAR    { get; set; }
        public abstract double Penghasilan();
    }
}
