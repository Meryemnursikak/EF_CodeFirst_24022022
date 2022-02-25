using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CodeFirst_24022022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OkulDatabase db = new OkulDatabase();

        private void Form1_Load(object sender, EventArgs e)
        {

            //db.Database.Create();

            dataGridView1.DataSource = db.Ogrenciler.ToList();
            dataGridView1.Columns["Ogrid"].Visible = false;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Okulno = txtno.Text;
            ogr.Isim = txtad.Text;
            ogr.Soyisim = txtsoyad.Text;
            ogr.Tcno = txttc.Text;

   
            MessageBox.Show("Kayıt Başarılı");
            db.Ogrenciler.Add(ogr);
            db.SaveChanges();
        }

       
    }
}
