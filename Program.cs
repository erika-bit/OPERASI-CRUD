using System;
using System.Collections.Generic;
using Tugas_Lab_9.Class_Anak;
using Tugas_Lab_9.Class_Induk;

namespace Tugas_Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {

            // Objek class collection
            List<Karyawan> listkaryawan = new List<Karyawan>();

            void OpenKaryawan()
            {
                int Urutan = 1;

                foreach (Karyawan karyawan in listkaryawan)
                {
                        Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}, {4}", 
                        Urutan, karyawan.NIK, karyawan.NAMA, karyawan.Penghasilan(), karyawan.JUMKAR); Urutan++;
                }
            }

            void DeleteKaryawan()
            {
                int Nomer = 1;
                int JumlahKryawan = 0;

                foreach (Karyawan karyawan in listkaryawan)
                {
                    Console.WriteLine("{0}. Nik: {1}", Nomer, karyawan.NIK); Nomer++; JumlahKryawan += 1;
                }

                
                Console.WriteLine("====================================");
                Console.Write("Pilih Data Yang Ingin Dihapus [1...");
                Console.Write(JumlahKryawan);
                Console.Write("] : ");
                int Indeks = int.Parse(Console.ReadLine());
                Indeks = Indeks - 1;
                listkaryawan.RemoveAt(Indeks);
                Console.WriteLine();
                Console.WriteLine("Data Karyawan Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\n Enter");
            }

            void PenambahanKH(string nama, string nik, string jumkar, int jamkerja, int upah)
            {
                listkaryawan.Add(new KaryawanHarian { NAMA = nama, NIK = nik, JUMKAR = jumkar, JamKerja = jamkerja, Upah = upah });
            }

            void PenambahanKT(string nama, string nik, string jumkar, double gajian)
            {
                listkaryawan.Add(new KaryawanTetap { NAMA = nama, NIK = nik, Gajian = gajian, JUMKAR = jumkar });
            }

            void Salesman(string nama, string nik, string jumkar, int jumlahpenjualan, int komisi)
            {
                listkaryawan.Add(new Sales { NAMA = nama, NIK = nik, JUMKAR = jumkar, JumlahPenjualan = jumlahpenjualan, Bonus = komisi });
            }

            bool keluar = false;
            while (keluar == false)
            {
                Console.Title = "Tugas Lab 9 (Pertemuan 12)- Polymorphsim, Inheritance, Abstraction & Collection Part #2";
                Console.WriteLine("\t\tMenu Aplikasi");
                Console.WriteLine("===========================================");
                Console.WriteLine("\t1. Tambah Data Karyawan");
                Console.WriteLine("\t2. Hapus Data Karyawan");
                Console.WriteLine("\t3. Tampilkan Data Karyawan");
                Console.WriteLine("\t4. Keluar");
                Console.WriteLine("===========================================");
                Console.Write("Nomer Menu [1..4] = ");
                int MENU = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                if (MENU < 1)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (MENU > 4)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (MENU == 1)
                {
                    Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine("====================");
                    Console.WriteLine();
                    Console.Write("\tJenis Karyawan \n1. Karyawan Tetap,\n2. Karyawan Harian,\n3. Sales,\n\n Pilih :  ");
                    int Jumkar = int.Parse(Console.ReadLine());
                    Console.WriteLine("====================");
                    if (Jumkar == 1)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Gaji Bulanan = ");
                        int bulanan = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Tetap";

                        PenambahanKT(jenis, nik, nama, bulanan);
                    }
                    else if (Jumkar == 2)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja = ");
                        int jamkerja = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam = ");
                        int upah = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Harian";

                        PenambahanKH (jenis, nik, nama, jamkerja, upah);
                    }
                    else if (Jumkar == 3)
                    {

                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jual = ");
                        int penjualan = int.Parse(Console.ReadLine());
                        Console.Write("Komisi = ");
                        int bonus = int.Parse(Console.ReadLine());
                        string jenis = "Sales";

                        Salesman(jenis, nik, nama, penjualan, bonus);
                    }
                    else
                    {
                        Console.WriteLine("Menu salah");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\n Enter");


                }
                else if (MENU == 2)
                {
                    DeleteKaryawan();
                }
                else if (MENU == 3)
                {
                    Console.WriteLine("Data Karyawan");
                    Console.WriteLine();
                    OpenKaryawan();

                    Console.WriteLine("\nEnter ");
                }
                else if (MENU == 4)
                {
                    keluar = true;
                }

                Console.ReadLine();
            }
        }
    }
}
