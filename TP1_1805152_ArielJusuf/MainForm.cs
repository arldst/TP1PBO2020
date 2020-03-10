using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_1805152_ArielJusuf
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Instansiasi List Barang
            List<Barang> barangList = new List<Barang>();

            // Menambah barang ke dalam list
            barangList.Add(new Barang(1, "Kaos Putih", "Baju", 400000, "Kaos berwarna putih", "1.jpg"));
            barangList.Add(new Barang(2, "Nasi", "Makanan", 150000, "Beras yang dimasak", "2.jpg"));
            barangList.Add(new Barang(3, "Kemeja Hitam", "Baju", 500000, "Kemeja berwarna hitam", "3.jpg"));
            barangList.Add(new Barang(4, "TV 4K", "Elektronik", 800000, "TV beresolusi Ultra HD", "4.jpg"));
            barangList.Add(new Barang(5, "Speaker", "Elektronik", 300000, "Panci untuk masak", "5.jpg"));

            int[] angka = new int[10];
            angka[0] = 1; angka[1] = 2;
            int i = 0;
            foreach(Barang item in barangList)
            {
                PictureBox pic = new PictureBox();
                Point p4 = new Point(240 + i * 120, 180);
                pic.Location = p4;
                pic.Name = "pic" + Convert.ToString(i);
                string curdir = System.IO.Directory.GetCurrentDirectory();
                pic.Image = Image.FromFile(curdir + "\\" + item.imagePath);
                pic.Size = new System.Drawing.Size(125, 125);
                pic.Visible = true;
                this.Controls.Add(pic);

                Label label1 = new Label();
                Point p1 = new Point(240 + i * 120, 320);
                label1.Location = p1;
                label1.Name = "labelBarang" + Convert.ToString(i);
                label1.Text = item.nama;
                label1.Visible = true;
                this.Controls.Add(label1);

                Label label2 = new Label();
                Point p2 = new Point(240 + i * 120, 350);
                label2.Location = p2;
                label2.Name = "labelHarga" + Convert.ToString(i);
                label2.Text = "Rp." + item.harga;
                label2.Visible = true;
                this.Controls.Add(label2);

                Button btn = new Button();
                Point p3 = new Point(240 + i * 120, 400);
                btn.Location = p3;
                btn.Name = "btnBeli" + Convert.ToString(i);
                btn.Text = "Beli";
                btn.Visible = true;
                this.Controls.Add(btn);

                i = i + 1;
            }
        }

        private void logoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void linkToKatalog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tokopedia.com");
        }
    }
}
