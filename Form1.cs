using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb; //acces kutuphanemizi eklıyoruz..

namespace Fatura_Takip
{
    public partial class Form1Sil : Form
    {
        public Form1Sil()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Fatura_Takip.accdb");

        OleDbDataAdapter da;
        DataTable tablo;
        OleDbCommandBuilder cb;
        OleDbCommand komut;

        TimeSpan fark;
        double gunfark;


        void listele()
        {
            da = new OleDbDataAdapter("SELECT *From Fatura_Bilgi ", baglan);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        void renlendirme()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                fark = Convert.ToDateTime(dataGridView1.Rows[i].Cells["Fatura_Son_Tarih"].Value.ToString()) - Convert.ToDateTime(DateTime.Now.ToShortDateString());
                gunfark = fark.TotalDays;

                bool odeme = Convert.ToBoolean(dataGridView1.Rows[i].Cells["Odendi"].Value);
                if (gunfark <= 3 && odeme == false)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (gunfark > 3 && gunfark < 7 && odeme == false)//&& odeme == false
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;

                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }


        void toplama()
        {
            baglan.Open();
            komut = new OleDbCommand("select sum(Fatura_Tutar) from Fatura_Bilgi", baglan);
            label6ToplamTutar.Text = komut.ExecuteScalar() + " TL";
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglan.Open();
            komut = new OleDbCommand("select sum(Fatura_Tutar) from Fatura_Bilgi ", baglan);
            label6ToplamTutar.Text = komut.ExecuteScalar() + " TL";
            baglan.Close();

            label7Bugun_Tarih.Text = DateTime.Now.ToShortDateString();
            listele();
            renlendirme();

            /*
            dataGridView1.Columns[0].Visible = false;
            renklendir();
            dataGridView1.Columns[1].HeaderText = "Fatura Cinsi";
            dataGridView1.Columns[2].HeaderText = "Fatura Tarihi";
            dataGridView1.Columns[3].HeaderText = "Son Ödeme Tarihi";
            dataGridView1.Columns[4].HeaderText = "Tutar";
            dataGridView1.Columns[5].HeaderText = "Ödeme Yapıldı";
            */

        }

        private void button3Duzenle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            cb = new OleDbCommandBuilder(da);
            da.Update(tablo);
            MessageBox.Show("Güncelleme işlemi Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            renlendirme();

            baglan.Close();
            toplama();
        }

        private void button1Ekle_Click(object sender, EventArgs e)
        {
            /*  baglantim.Open();
            komut = new OleDbCommand();
            komut.Connection = baglantim;
            komut.CommandText = "select *from kaynarca_bilgiler";
            OleDbDataReader oku = komut.ExecuteReader();
                         */
            if (textBox1.Text != "" && dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && textBox2.Text != "")
            {
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into Fatura_Bilgi (Fatura_ismi,Fatura_Baslangic_Tarih,Fatura_Son_Tarih,Fatura_Tutar) values ('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + Convert.ToDouble(textBox2.Text) + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                listele();
                renlendirme();
                toplama();
            }
            else
            {
                MessageBox.Show("Alanları boş Geçmeyiniz..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*
            string sorgu = "Insert into Ogrenci (numara,ad,soyad,telefon) values (@no,@ad,@soyad,@tel)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", Convert.ToInt32(textBox1.Text));
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@tel", textBox4.Text);
                */

            }


        }

        private void button1Sil_Click(object sender, EventArgs e)

        {
            DialogResult cvp = MessageBox.Show(" Tüm " + textBox1.Text + " Faturası Silmek istediginizden eminmisiniz..?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (textBox1.Text != "")
            {

                if (cvp == DialogResult.Yes)
                {
                    baglan.Open();
                    komut = new OleDbCommand("delete *from Fatura_Bilgi where Fatura_ismi='" + textBox1.Text + "'", baglan);
                    komut.ExecuteNonQuery();
                    listele();

                    renlendirme();
                    MessageBox.Show("Tüm " + textBox1.Text + " FAturası Silindi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglan.Close();
                    toplama();


                }
                else if (cvp == DialogResult.No)
                {
                    listele();
                    renlendirme();

                }


            }
            else
            {

                MessageBox.Show(" Silinecek Fatura ismini yazınız..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }
    }
}
