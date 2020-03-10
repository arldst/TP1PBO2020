using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_1805152_ArielJusuf
{
    class Barang
    {
        // Atribut Class
        public int id { get; set; }
        public string nama { get; set; }
        public string jenis { get; set; }
        public int harga { get; set; }
        public string deskripsi { get; set; }
        public string imagePath { get; set; }

        public Barang() { }
        public Barang(int id, string nama, string jenis, int harga, string deskripsi, string imagePath)
        {
            this.id = id;
            this.nama = nama;
            this.jenis = jenis;
            this.harga = harga;
            this.deskripsi = deskripsi;
            this.imagePath = imagePath;
        }
    }
}
