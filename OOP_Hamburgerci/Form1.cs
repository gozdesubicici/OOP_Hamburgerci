using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi="Big King", Fiyati=18.25M},
            new Menu{MenuAdi="Double King Chicken", Fiyati=19.75M},
            new Menu{MenuAdi="Steakhouse", Fiyati=22.50M},
            new Menu{MenuAdi="Whooper", Fiyati=20.00M},
            new Menu{MenuAdi="Whooper Jr.", Fiyati=17.75M},
            new Menu{MenuAdi="Chicken Royal", Fiyati=21.25M}
        };

        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra{EkstraAdi="Ketçap", Fiyati=0.50M},
            new Ekstra{EkstraAdi="Mayonez", Fiyati=0.50M},
            new Ekstra{EkstraAdi="Hardal", Fiyati=0.75M},
            new Ekstra{EkstraAdi="BBQ", Fiyati=1.00M},
            new Ekstra{EkstraAdi="Ranch", Fiyati=1.00M},
            new Ekstra{EkstraAdi="Buffalo", Fiyati=1.25M}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
            {
                cmbMenular.Items.Add(item); // ToString() metodunu override ettiğimiz için ... Menü şeklinde bastırılacak
            }
                
            foreach (Ekstra item in ekstralar)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text =item.EkstraAdi, Tag=item});
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lbxSiparisler.Items.Add(item); // Form açıldığında mevcut siparişler varsa listBox'a ekleyecek.
            }

            TutarHesapla();

            rdoKucuk.Checked = true;
            cmbMenular.SelectedIndex = 0; // -1 olursa herhangi bir eleman seçili olmaz. 0 olursa ilk eleman seçili gelecektir.

        }
        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");

            return toplamTutar;
        }
        

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenusu = (Menu)cmbMenular.SelectedItem;

            if (rdoKucuk.Checked)
                yeniSiparis.Boyutu = Boyut.Kucuk;
            else if (rdoOrta.Checked)
                yeniSiparis.Boyutu = Boyut.Orta;
            else
                yeniSiparis.Boyutu = Boyut.Buyuk;

            yeniSiparis.EkstraMalzemesi = new List<Ekstra>();
            foreach (CheckBox flpCtrl in flpEkstraMalzemeler.Controls)
            {
                if (flpCtrl.Checked)
                    yeniSiparis.EkstraMalzemesi.Add((Ekstra)flpCtrl.Tag); //FLP'nin kontrollerinden seçilenlerin her birinin Tag property'sinde tutulan ekstra malzemenin bir kopyasını verir.

            }
            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla(); //Class'ta yazılan metot sayesinde ToplamTutar hesaplanıp ilgili property'ye aktarılacaktır.

            tumSiparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();

            // TODO: Fonksiyonlar isimli bir Class oluşturunuz ve temizle isimli metot oluşturup buradaki her kontrolü temizleyiniz.
            // Menü ComboBox'ı ilk eleman seçili hale gelecek.
            // Boyut Küçük radioButton seçili hale gelecek.
            // Malzeme flowLayoutPanel'deki CheckBox'ların checked'i kaldırılacak.
            // Adet numericUpDown (1) yani minimum değere çekilecek.

        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla().ToString("C2") + "\nSatın almayı tamamlamak ister misiniz?", "Sipariş Bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla(); // Label'daki değeri temizlemesi için (₺0,00)
                MessageBox.Show("Siparişiniz Tamamlandı!");
            }
            else
            {
                MessageBox.Show("İptal Edildi!");
            }
        }
    }
}
