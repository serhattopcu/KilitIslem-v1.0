using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
namespace Kilit
{
    public partial class girisform : Form
    {
        public girisform()
        {
            InitializeComponent();
        }

        public static string cinsiyet = "", isim = "";
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/usersdb.mdb");
        public bool girisKontrol = false;

        private void btn_giris_Click(object sender, EventArgs e)
        {
            isim = tx_ad.Text;
            if ((isim != "") && (cinsiyet != ""))
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    OleDbCommand komut = new OleDbCommand("INSERT INTO Users(KullanıcıAdı,Cinsiyet)VALUES('" + isim + "','" + cinsiyet + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    girisKontrol = true;
                    oyunform frm = new oyunform();
                    frm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Bilgileri eksik ya da hatalı girdiniz.Lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tx_ad.Text = ""; isim = ""; cinsiyet = "";
            }
        }
        private void rd_btn_erkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }
        private void rd_btn_kız_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kadın";
        }
    }
}
