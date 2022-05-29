using System;
using System.Drawing;
using System.Windows.Forms;

namespace IsimSehirHayvan
{
    public partial class Form1 : Form
    {
        private char secilenHarf;
        private char[] tumHarfler = new char[] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
        private int gecenSure;
        private string[] isimler;
        private string[] sehirler;
        private int toplamPuan = 0;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IsimListesi();
            SehirListesi();
        }
        private void btnHarfVer_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            secilenHarf = tumHarfler[rnd.Next(0, tumHarfler.Length)];
            lblHarf.Text = "Harf: " + secilenHarf.ToString();
            btnBaslat.Enabled = true;
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            gecenSure = 0;
            btnKontrolEt.Enabled = true;
            btnHarfVer.Enabled = false;
            tSure.Start();
            foreach (Control item in tableSoruPaneli.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void tSure_Tick(object sender, EventArgs e)
        {
            gecenSure += 1;
            if (gecenSure == 60)
            {
                tSure.Stop();
                btnKontrolEt.Enabled = false;
                btnBaslat.Enabled = true;
                MessageBox.Show("Süre doldu!");
            }
            lblZaman.Text = "Zaman: " + gecenSure;
        }

        /// <summary>
        /// Kaynaklarda bulunan isimler.txt dosyasını okur ve isimler dizisine atama yapar.
        /// </summary>
        private void IsimListesi()
        {
            try
            {
                isimler = Properties.Resources.isimler.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            }
            catch
            {
                MessageBox.Show("İsim listesi alınırken hata oluştu. Program kapatılacak.");
                Close();
            }
        }

        /// <summary>
        /// Kaynaklarda bulunan sehirler.txt dosyasını okur ve sehirler dizisine atama yapar.
        /// </summary>
        private void SehirListesi()
        {
            try
            {
                sehirler = Properties.Resources.sehirler.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            }
            catch
            {
                MessageBox.Show("Şehir listesi alınırken hata oluştu. Program kapatılacak.");
                Close();
            }
        }

        /// <summary>
        /// Girilen ismin kurallara uygun ve listede olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="isim">Girilen isim</param>
        /// <returns>boolean olarak doğru ya da yanlış değerini döndürür.</returns>
        private bool IsimKontrolEt(string girilenIsim)
        {
            if (girilenIsim.Length < 2) return false;
            if (char.ToUpper(girilenIsim[0]) != secilenHarf || char.ToUpperInvariant(girilenIsim[0]) != secilenHarf) return false;
            if (Array.FindIndex(isimler, t => t.IndexOf(girilenIsim, StringComparison.InvariantCultureIgnoreCase) != -1) == -1) return false;
            return true;
        }

        /// <summary>
        /// Girilen şehrin kurallara uygun ve listede olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="girilenSehir">Girilen şehir</param>
        /// <returns>boolean olarak doğru ya da yanlış değerini döndürür</returns>
        private bool SehirKontrolEt(string girilenSehir)
        {
            if (girilenSehir.Length < 3) return false;
            if (char.ToUpper(girilenSehir[0]) != secilenHarf || char.ToUpperInvariant(girilenSehir[0]) != secilenHarf) return false;
            if (Array.FindIndex(sehirler, t => t.IndexOf(girilenSehir, StringComparison.InvariantCultureIgnoreCase) != -1) == -1) return false;
            return true;
        }

        private bool HayvanKontrolEt(string girilenHayvan)
        {
            if (girilenHayvan.Length < 2) return false;
            if (char.ToUpper(girilenHayvan[0]) != secilenHarf || char.ToUpperInvariant(girilenHayvan[0]) != secilenHarf) return false;
            return true;
        }
        private bool BitkiKontrolEt(string girilenBitki)
        {
            if (girilenBitki.Length < 3) return false;
            if (char.ToUpper(girilenBitki[0]) != secilenHarf || char.ToUpperInvariant(girilenBitki[0]) != secilenHarf) return false;
            return true;
        }
        private bool EsyaKontrolEt(string girilenEsya)
        {
            if (girilenEsya.Length < 3) return false;
            if (char.ToUpper(girilenEsya[0]) != secilenHarf || char.ToUpperInvariant(girilenEsya[0]) != secilenHarf) return false;
            return true;
        }
        private bool UnluKontrolEt(string girilenUnlu)
        {
            if (girilenUnlu.Length < 5) return false;
            if (char.ToUpper(girilenUnlu[0]) != secilenHarf || char.ToUpperInvariant(girilenUnlu[0]) != secilenHarf) return false;
            return true;
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            if (gecenSure > 59)
            {
                MessageBox.Show("Süre dolmuş ! Puan alamayacaksınız.");
            }
            else
            {
                string girilenIsim = txtIsim.Text.Trim();
                string girilenSehir = txtSehir.Text.Trim();
                string girilenHayvan = txtHayvan.Text.Trim();
                string girilenBitki = txtBitki.Text.ToString();
                string girilenEsya = txtEsya.Text.ToString();
                string girilenUnlu = txtUnlu.Text.ToString();

                if (IsimKontrolEt(girilenIsim))
                {
                    toplamPuan += 10;
                    pbIsim.BackColor = Color.Green;
                }
                else
                {
                    pbIsim.BackColor = Color.Red;
                }
                if (SehirKontrolEt(girilenSehir))
                {
                    toplamPuan += 10;
                    pbSehir.BackColor = Color.Green;
                }
                else
                {
                    pbSehir.BackColor = Color.Red;
                }
                if (HayvanKontrolEt(girilenHayvan))
                {
                    toplamPuan += 10;
                    pbHayvan.BackColor = Color.Green;
                }
                else
                {
                    pbHayvan.BackColor = Color.Red;
                }
                if (BitkiKontrolEt(girilenBitki))
                {
                    toplamPuan += 10;
                    pbBitki.BackColor = Color.Green;
                }
                else
                {
                    pbBitki.BackColor = Color.Red;
                }
                if (EsyaKontrolEt(girilenEsya))
                {
                    toplamPuan += 10;
                    pbEsya.BackColor = Color.Green;
                }
                else
                {
                    pbEsya.BackColor = Color.Red;
                }
                if (UnluKontrolEt(girilenUnlu))
                {
                    toplamPuan += 10;
                    pbUnlu.BackColor = Color.Green;
                }
                else
                {
                    pbUnlu.BackColor = Color.Red;
                }

                lblPuan.Text = "Puan: " + toplamPuan;

                btnBaslat.Enabled = false;
                btnHarfVer.Enabled = true;
                btnKontrolEt.Enabled = false;
                tSure.Stop();
                lblZaman.Text = "Zaman: ";
                lblHarf.Text = "Harf: ";
            }
        }


    }
}
