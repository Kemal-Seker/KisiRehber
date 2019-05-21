using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_KisiRehber
{
    public partial class frmKisiEkleGuncelle : Form
    {
        private List<Kisi> kisiler;
        public frmKisiEkleGuncelle()
        {
            InitializeComponent();
            kisiler = new List<Kisi>();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            EkleControlTemizle();
        }

        private void EkleControlTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            rchAdres.Clear();
            txtAd.Focus();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            grbEkle.Enabled = true;
            grbGuncelle.Enabled = false;
            GuncelleControlTemizle();
            txtAdGuncelle.Focus();
        }

        private void GuncelleControlTemizle()
        {
            txtAdGuncelle.Clear();
            txtSoyadGuncelle.Clear();
            txtTelefonGuncelle.Clear();
            rchAdresGuncelle.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           Kisi YeniKisi= new Kisi(txtAd.Text,txtSoyad.Text,txtTelefon.Text,rchAdres.Text); 
           kisiler.Add(YeniKisi);
           // ListView için bir satır oluşturduk
           ListViewItem kisiItem = new ListViewItem();
           kisiItem.SubItems[0].Text = YeniKisi.Ad + " " + YeniKisi.Soyad; // İlk sutuna bir değer ataması yapmak

           ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem(); // ikinci bir sutun oluşturduk
           sub.Text = YeniKisi.Telefon;
           kisiItem.SubItems.Add(sub);  //kisiItem.SubItems.Add(YeniKisi.Telefon); // buraya ekleyerek 

           listGoruntule.Items.Add(kisiItem); // burda da kendi ListView elemanımıza eklenmiş oluyor.
           EkleControlTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var seciliTelefon = listGoruntule.SelectedItems[0].SubItems[1].Text;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Telefon == seciliTelefon)
                {
                    kisiler[i].Ad = txtAdGuncelle.Text;
                    kisiler[i].Soyad = txtSoyadGuncelle.Text;
                    kisiler[i].Telefon = txtTelefonGuncelle.Text;
                    kisiler[i].Adres = rchAdresGuncelle.Text;

                    var secili = listGoruntule.SelectedItems[0];
                    secili.SubItems[0].Text = kisiler[i].Ad +" "+ kisiler[i].Soyad;
                    secili.SubItems[1].Text = kisiler[i].Telefon;
                    
                    break;
                }
            }

            grbEkle.Enabled = true;
            GuncelleControlTemizle();
        }

        private void listGoruntule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGoruntule.SelectedItems.Count<=0)
            {
                return; // eğer hiç seçili Item yok ise Metodu bitir. Aşağıya hiç uğramaz. 
            }
            grbGuncelle.Enabled = true;
            grbEkle.Enabled = false;

            var seciliTelefon = listGoruntule.SelectedItems[0].SubItems[1].Text;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Telefon == seciliTelefon)
                {
                    txtAdGuncelle.Text = kisiler[i].Ad;
                    txtSoyadGuncelle.Text = kisiler[i].Soyad;
                    txtTelefonGuncelle.Text = kisiler[i].Telefon;
                    rchAdresGuncelle.Text = kisiler[i].Adres;
                    break;
                }
            }

            //txtAdGuncelle.Text = listGoruntule.SelectedItems[0].Text.Split(' ')[0];
        }

        private void frmKisiEkleGuncelle_Load(object sender, EventArgs e)
        {
            grbGuncelle.Enabled = false;
        }
    }
}
