using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kilit
{
    public partial class oyunform : Form
    {
        public oyunform()
        {
            InitializeComponent();
        }

        private void lb_soruid_Click(object sender, EventArgs e)
        {

        }

        OleDbConnection baglantı2 = new OleDbConnection();
        public static int x;
        public int yanlıssayac = 0;
        public int dogrusayac = 0;
        public int puan = 0;
        public int sorusayac = 0;
        public int sorucek(int id)
        {


            baglantı2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/usersdb.mdb";
            baglantı2.Open();

            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı2;
            komut.CommandText = "Select sayısalsoru,sozelsoru,Seviye,Puan From soruseti where soruId=" + id + "";
            komut.ExecuteNonQuery();
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                btn_soru.Text = dr["sayısalsoru"].ToString();
                lb_sorulan.Text = dr["sozelsoru"].ToString();
                lb_soruid.Text = Convert.ToString(id);
                lb_seviye.Text = dr["Seviye"].ToString();
                lbs_puan.Text = dr["Puan"].ToString();
            }
            else
                MessageBox.Show("veri çekilmedi");
            baglantı2.Close();
            return 0;

        }

        public string cevapcek(int cid)
        {
            string cevap = "";
            OleDbConnection baglantı3 = new OleDbConnection();
            baglantı3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/usersdb.mdb";
            baglantı3.Open();

            OleDbCommand komut2 = new OleDbCommand();
            komut2.Connection = baglantı3;
            komut2.CommandText = "Select Cevap From soruseti where soruId=" + cid + "";
            komut2.ExecuteNonQuery();
            OleDbDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                cevap = dr["Cevap"].ToString();
            }
            else
                MessageBox.Show("veri çekilmedi");
            baglantı2.Close();
            return cevap;

        }
        public void btnGuncelleme()
        {
            sorusayac++;
            dogrusayac++;
            lb_dsayac.Text = Convert.ToString(dogrusayac);
            puan = puan + Convert.ToInt32(lbs_puan.Text);
            lbl_puan.Text = Convert.ToString(puan);
            btn_soru.Text = "";
            lb_sorulan.Text = "";
            lb_seviye.Text = "";
            lbs_puan.Text = "";
            lb_soruid.Text = "";
        }
        public void btnGuncelleme2()
        {

            yanlıssayac++;
            lbl_ysayac.Text = Convert.ToString(yanlıssayac);
            puan = puan - Convert.ToInt32(lbs_puan.Text);
            lbl_puan.Text = Convert.ToString(puan);
        }
   
       








     
        private void button76_Click(object sender, EventArgs e)
        {
            if ((a1.Text == "B") && (a2.Text == "İ") && (a3.Text == "L") && (a4.Text == "İ") && (a5.Text == "M") && (a6.Text == "S") && (a7.Text == "E") && (a8.Text == "L"))

                lb_tebrik.Text = "Tebrikler!!";
            else
                lb_tebrik.Text = "Yanlış tahmin";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı2.Open();
            string kAdi = girisform.isim;
            OleDbCommand komutt = new OleDbCommand("Update Users set SoruSayisi=" + sorusayac + " , DogruSayisi=" + dogrusayac + ",YanlisSayisi=" + yanlıssayac + ",Puan=" + puan +
                " WHERE KullanıcıAdı='" + kAdi + "'", baglantı2);
            komutt.ExecuteNonQuery();
            komutt.Dispose();
            baglantı2.Close();
            analizform aform = new analizform();

            aform.Show();
        }
         
        
        //-------------------------------------------------------------
        private void b1_Click(object sender, EventArgs e)
        {
            x = 1;
            sorucek(x);
        }
       
        private void btn_c11_Click(object sender, EventArgs e)
        {
            if (btn_c11.Text == cevapcek(x))
            {
                btn_c11.Hide();
                b1.Text = "B";
                b1.Font = new Font("Arial", 13, FontStyle.Underline, GraphicsUnit.Point);
                a1.Text = "B";
                b1.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b2_Click(object sender, EventArgs e)
        {
             x = 2;
            sorucek(x);
        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
           if (btn_c1.Text == cevapcek(x))
            {
                btn_c1.Hide();
                b2.Text = "İ";
                b2.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
        }
        }
        //-------------------------------------------------------------

        private void b3_Click(object sender, EventArgs e)
        {
            x = 3;
            sorucek(x);
        }

        private void btn_c16_Click(object sender, EventArgs e)
        {
            if (btn_c16.Text == cevapcek(x))
            {
                btn_c16.Hide();
                b3.Text = "R";
                b3.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------

        private void b4_Click(object sender, EventArgs e)
        {
            x = 4;
            sorucek(x);
        }

        private void btn_c22_Click(object sender, EventArgs e)
        {
            if (btn_c22.Text == cevapcek(x))
            {
                btn_c22.Hide();
                b4.Text = "Ö";
                b4.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b5_Click(object sender, EventArgs e)
        {
            x = 5;
            sorucek(x);
        }

        private void btn_c7_Click(object sender, EventArgs e)
        {
            if (btn_c7.Text == cevapcek(x))
            {
                btn_c7.Hide();
                b5.Font = new Font("Arial", 13, FontStyle.Underline, GraphicsUnit.Point);
                b5.Text = "İ";
                a2.Text = "İ";
                b5.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b6_Click(object sender, EventArgs e)
        {
            x = 6;
            sorucek(x);
        }

        private void btn_c17_Click(object sender, EventArgs e)
        {
            if (btn_c17.Text == cevapcek(x))
            {
                b6.Font = new Font("Arial", 13, FontStyle.Underline, GraphicsUnit.Point);
                btn_c17.Hide();
                b6.Text = "L";
                a3.Text = "L";
                b6.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b7_Click(object sender, EventArgs e)
        {
            x = 7;
            sorucek(x);
        }
        
        private void btn_c10_Click(object sender, EventArgs e)
        {
            if (btn_c10.Text == cevapcek(x))
            {
                btn_c10.Hide();
                b7.Text = "K";
                b7.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b8_Click(object sender, EventArgs e)
        {
            x = 8;
            sorucek(x);
        }
        private void btn_c26_Click(object sender, EventArgs e)
        {
            if (btn_c26.Text == cevapcek(x))
            {
                btn_c26.Hide();
                b8.Text = "Ö";
                b8.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b9_Click(object sender, EventArgs e)
        {
            x = 9;
            sorucek(x);
        }
        private void btn_c3_Click(object sender, EventArgs e)
        {
            if (btn_c3.Text == cevapcek(x))
            {
                b9.Font = new Font("Arial", 13, FontStyle.Underline, GraphicsUnit.Point);
                btn_c3.Hide();
                b9.Text = "İ";
                a4.Text = "İ";
                b9.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }

        //-------------------------------------------------------------
        private void b10_Click(object sender, EventArgs e)
        {
            x = 10;
            sorucek(x);
        }
        private void btn_c28_Click(object sender, EventArgs e)
        {
            if (btn_c28.Text == cevapcek(x))
            {
                btn_c28.Hide();
                b10.Text = "K";
                b10.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b11_Click(object sender, EventArgs e)
        {
            x =11;
            sorucek(x);
        }
        private void btn_c5_Click(object sender, EventArgs e)
        {
            if (btn_c5.Text == cevapcek(x))
            {
                btn_c5.Hide();
                b11.Text = "İ";
                b11.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b12_Click(object sender, EventArgs e)
        {
            x = 12;
            sorucek(x);
        }
        private void btn_c12_Click(object sender, EventArgs e)
        {
            if (btn_c12.Text == cevapcek(x))
            {
                btn_c12.Hide();
                b12.Text = "T";
                b12.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b13_Click(object sender, EventArgs e)
        {
            x = 13;
            sorucek(x);
        }
        private void btn_c20_Click(object sender, EventArgs e)
        {
            if (btn_c20.Text == cevapcek(x))
            {
                btn_c20.Hide();
                b13.Text = "O";
                b13.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b14_Click(object sender, EventArgs e)
        {
            x = 14;
            sorucek(x);
        }
        private void btn_c24_Click(object sender, EventArgs e)
        {
            if (btn_c24.Text == cevapcek(x))
            {
                btn_c24.Hide();
                b14.Text = "P";
                b14.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b15_Click(object sender, EventArgs e)
        {
            x = 15;
            sorucek(x);
        }
        private void btn_c25_Click(object sender, EventArgs e)
        {
            if (btn_c25.Text == cevapcek(x))
            {
                btn_c25.Hide();
                b15.Text = "L";
                a8.Text = "L";
                b15.Enabled = false;
                b15.Font = new Font("Arial", 13, FontStyle.Underline, GraphicsUnit.Point);

                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b16_Click(object sender, EventArgs e)
        {
            x = 16;
            sorucek(x);
        }
        private void btn_c23_Click(object sender, EventArgs e)
        {
            if (btn_c23.Text == cevapcek(x))
            {
                btn_c23.Hide();
                b16.Text = "A";
                b16.Enabled = false;
                btnGuncelleme();
            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b17_Click(object sender, EventArgs e)
        {
            x = 17;
            sorucek(x);
        }
        private void btn_c29_Click(object sender, EventArgs e)
        {
            if (btn_c29.Text == cevapcek(x))
            {
                btn_c29.Hide();
                b17.Text = "M";
                a5.Text = "M";
                b17.Enabled = false;
                btnGuncelleme();
                b17.Font = new Font("Arial", 13, FontStyle.Underline, GraphicsUnit.Point);

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b18_Click(object sender, EventArgs e)
        {
            x = 18;
            sorucek(x);
        }
        private void btn_c21_Click(object sender, EventArgs e)
        {
            if (btn_c21.Text == cevapcek(x))
            {
                btn_c21.Hide();
                b18.Text = "A";
                b18.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b19_Click(object sender, EventArgs e)
        {
            x = 19;
            sorucek(x);
        }
        private void btn_c2_Click(object sender, EventArgs e)
        {
            if (btn_c2.Text == cevapcek(x))
            {
                btn_c2.Hide();
                b19.Text = "B";
                b19.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b20_Click(object sender, EventArgs e)
        {
            x = 20;
            sorucek(x);
        }
        private void btn_c18_Click(object sender, EventArgs e)
        {
            if (btn_c18.Text == cevapcek(x))
            {
                btn_c18.Hide();
                b20.Text = "Ü";
                b20.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b21_Click(object sender, EventArgs e)
        {
            x = 21;
            sorucek(x);
        }
        private void btn_c19_Click(object sender, EventArgs e)
        {
            if (btn_c19.Text == cevapcek(x))
            {
                btn_c19.Hide();
                b21.Text = "E";
                a7.Text = "E";
                b21.Enabled = false;
                btnGuncelleme();
                b21.Font = new Font("Arial", 13, FontStyle.Underline, GraphicsUnit.Point);

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b22_Click(object sender, EventArgs e)
        {
            x = 22;
            sorucek(x);
        }
        private void btn_c15_Click(object sender, EventArgs e)
        {
            if (btn_c15.Text == cevapcek(x))
            {
                btn_c15.Hide();
                b22.Text = "Ş";
                b22.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b23_Click(object sender, EventArgs e)
        {
            x = 23;
            sorucek(x);
        }
        private void btn_c8_Click(object sender, EventArgs e)
        {
            if (btn_c8.Text == cevapcek(x))
            {
                btn_c8.Hide();
                b23.Text = "S";
                a6.Text = "S";
                b23.Enabled = false;
                btnGuncelleme();
                b23.Font = new Font("Arial", 13, FontStyle.Underline, GraphicsUnit.Point);

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b24_Click(object sender, EventArgs e)
        {
            x = 24;
            sorucek(x);
        }
        private void btn_c14_Click(object sender, EventArgs e)
        {
            if (btn_c14.Text == cevapcek(x))
            {
                btn_c14.Hide();
                b24.Text = "A";
                b24.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b25_Click(object sender, EventArgs e)
        {
            x = 25;
            sorucek(x);
        }
        private void btn_c9_Click(object sender, EventArgs e)
        {
            if (btn_c9.Text == cevapcek(x))
            {
                btn_c9.Hide();
                b25.Text = "Y";
                b25.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b26_Click(object sender, EventArgs e)
        {
            x = 26;
            sorucek(x);
        }
        private void btn_c4_Click(object sender, EventArgs e)
        {
            if (btn_c4.Text == cevapcek(x))
            {
                btn_c4.Hide();
                b26.Text = "I";
                b26.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
       
    
      
        //-------------------------------------------------------------
        private void b27_Click(object sender, EventArgs e)
        {
            x = 27;
            sorucek(x);
        }
        private void btn_c30_Click(object sender, EventArgs e)
        {
            if (btn_c30.Text == cevapcek(x))
            {
                btn_c30.Hide();
                b27.Text = "B";
                b27.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
        //-------------------------------------------------------------
        private void b28_Click(object sender, EventArgs e)
        {
            x = 28;
            sorucek(x);
        }
        private void btn_c27_Click(object sender, EventArgs e)
        {
            if (btn_c27.Text == cevapcek(x))
            {
                btn_c27.Hide();
                b28.Text = "A";
                b28.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
        
        
       
        //-------------------------------------------------------------
        private void b29_Click(object sender, EventArgs e)
        {
            x = 29;
            sorucek(x);

        }
        private void btn_c13_Click(object sender, EventArgs e)
        {
            if (btn_c13.Text == cevapcek(x))
            {
                btn_c13.Hide();
                b29.Text = "Y";
                b29.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
       
        //-------------------------------------------------------------
        private void b30_Click(object sender, EventArgs e)
        {
            x = 30;
            sorucek(x);
        }
        private void btn_c6_Click(object sender, EventArgs e)
        {
            if (btn_c6.Text == cevapcek(x))
            {
                btn_c6.Hide();
                b30.Text = "I";
                b30.Enabled = false;
                btnGuncelleme();

            }
            else
            {
                btnGuncelleme2();
            }
        }
        
        //-------------------------------------------------------------
      
        private void oyunform_Load(object sender, EventArgs e)
        {
            label2.Text = girisform.isim;
        }
        //-------------------------------------------------------------
       
    }
}
