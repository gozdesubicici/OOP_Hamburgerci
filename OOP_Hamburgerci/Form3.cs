using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Form1.ekstralar.Add(new Ekstra { EkstraAdi = txtEkstraMalz.Text, Fiyati = nmrEkstraFiyatı.Value });

            // TODO: Ekledikten sonra Temizle metodunu çağıralım.

            MessageBox.Show("Ekstra Malzeme Başarılı Şekilde Eklendi!");
        }
    }
}
